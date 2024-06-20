using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image imageToFade;
    public float fadeDuration = 2.0f;
    public GameObject preto;

    private void Start()
    {
        if (imageToFade != null)
        {
            // Inicialmente, certifique-se de que a imagem esteja invisível
            var tempColor = imageToFade.color;
            tempColor.a = 1f;
            imageToFade.color = tempColor;

            // Ativar a imagem e iniciar a coroutine de fade
            StartCoroutine(FadeIn());
        }
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0.0f;
        Color tempColor = imageToFade.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            tempColor.a = Mathf.Clamp01(elapsedTime / fadeDuration);
            imageToFade.color = tempColor;
            yield return null;
        }
    }
   
}
