using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject opcoes;
    public Image imageToFade;
    public float fadeDuration = 0.36f;

    public void Jogar()
    {
        if (imageToFade != null)
        {
            StartCoroutine(FadeIn());
        }
        Invoke("carregarCena", 0.36f);


    }

    public void Opcoes()
    {
        opcoes.SetActive(true);
        
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Sair()
    {
        Application.Quit();
    }
    public void carregarCena()
    {
        SceneManager.LoadScene("Cutscene");

    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0.0f;
        Color tempColor = imageToFade.color;
        tempColor.a = 0f; // Inicialmente, certifique-se de que a imagem esteja invisível
        imageToFade.color = tempColor;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            tempColor.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            imageToFade.color = tempColor;
            yield return null;
        }
    }
}
