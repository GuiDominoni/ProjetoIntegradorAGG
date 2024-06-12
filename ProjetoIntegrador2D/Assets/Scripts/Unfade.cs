using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Unfade : MonoBehaviour
{
    public Image imageToUnfade;
    public float fadeDuration = 2.0f;

    private void Start()
    {
        if (imageToUnfade != null)
        {
            // Inicialmente, certifique-se de que a imagem esteja visível
            var tempColor = imageToUnfade.color;
            tempColor.a = 1f;
            imageToUnfade.color = tempColor;

            // Ativar a imagem e iniciar a coroutine de unfade
            StartCoroutine(nfade());
        }
    }

    private IEnumerator nfade()
    {
        float elapsedTime = 0.0f;
        Color tempColor = imageToUnfade.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            tempColor.a = 1f - Mathf.Clamp01(elapsedTime / fadeDuration);
            imageToUnfade.color = tempColor;
            yield return null;
        }
    }
   
}
