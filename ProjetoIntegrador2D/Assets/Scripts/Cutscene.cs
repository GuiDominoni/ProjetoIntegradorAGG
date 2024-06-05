using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    public Image[] cutImages; // Array de imagens da cutscene
    private int currentImageIndex = 0; // Índice da imagem atual
    public float fadeDuration = 1.0f; // Duração do fade em segundos

    private bool isTransitioning = false; // Flag para indicar se a transição entre imagens está ocorrendo

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
        isTransitioning = true; // Indica que a transição está em andamento

        Image currentImage = cutImages[currentImageIndex];
        Image nextImage = cutImages[currentImageIndex + 1];

        // Fade out a imagem atual
        yield return StartCoroutine(FadeOut(currentImage));

        // Desativa a imagem atual
        currentImage.gameObject.SetActive(false);

        // Ative a próxima imagem
        nextImage.gameObject.SetActive(true);

        // Fade in a próxima imagem
        yield return StartCoroutine(FadeIn(nextImage));

        // Atualize o índice da imagem atual
        currentImageIndex++;
            
        isTransitioning = false; // Indica que a transição terminou
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
