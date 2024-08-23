using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public float typingSpeed = 0.05f; // Velocidade da digita��o
    public TextMeshProUGUI textComponent;

    private void Start()
    {
        textComponent.text = ""; // Inicia o texto como vazio
    }

    public void RunTypewriter(string text)
    {
        StopAllCoroutines(); // Para qualquer digita��o em andamento
        StartCoroutine(TypeText(text)); // Come�a o efeito de digita��o
    }

    private IEnumerator TypeText(string text)
    {
        foreach (char letter in text.ToCharArray())
        {
            textComponent.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
