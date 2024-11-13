using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Unfade : MonoBehaviour
{
    public Image imageToUnfade;
    public float fadeDuration = 2.0f;
        public GameObject preto;

    private void Start()
    {
        if (preto != null)
        {

            Invoke("desat", fadeDuration + 0.2f);
        }
        if (imageToUnfade != null)
        {
           
            var tempColor = imageToUnfade.color;
            tempColor.a = 1f;
            imageToUnfade.color = tempColor;

            
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
    void desat()
    {
        preto.SetActive(false); 

    }
   
}
