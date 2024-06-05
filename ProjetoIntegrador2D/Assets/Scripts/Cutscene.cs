using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    public Image[] cutImages; // Array de imagens da cutscene
    private int currentImageIndex = 0; // �ndice da imagem atual
    public float fadeDuration = 1.0f; // Dura��o do fade em segundos

    private bool isTransitioning = false; // Flag para indicar se a transi��o entre imagens est� ocorrendo

    private void Start()
    {
        // Inicialize apenas a primeira imagem com opacidade 1
        cutImages[0].color = new Color(1, 1, 1, 1);
    }

    public void Sair()
    {
        SceneManager.LoadScene("SelecaoNiveis");
    }

    public void Proximo()
    {
        if (!isTransitioning && currentImageIndex < cutImages.Length - 1)
        {
            StartCoroutine(FadeToNextImage());
        }
    }

    private IEnumerator FadeToNextImage()
    {
        isTransitioning = true; // Indica que a transi��o est� em andamento

        Image currentImage = cutImages[currentImageIndex];
        Image nextImage = cutImages[currentImageIndex + 1];

        // Fade out a imagem atual
        yield return StartCoroutine(FadeOut(currentImage));

        // Desativa a imagem atual
        currentImage.gameObject.SetActive(false);

        // Ative a pr�xima imagem
        nextImage.gameObject.SetActive(true);

        // Fade in a pr�xima imagem
        yield return StartCoroutine(FadeIn(nextImage));

        // Atualize o �ndice da imagem atual
        currentImageIndex++;
            
        isTransitioning = false; // Indica que a transi��o terminou
    }

    private IEnumerator FadeIn(Image image)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            image.color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }

    private IEnumerator FadeOut(Image image)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Clamp01(1.0f - (elapsedTime / fadeDuration));
            image.color = new Color(1, 1, 1, alpha);
            yield return null;
        }
    }
}
