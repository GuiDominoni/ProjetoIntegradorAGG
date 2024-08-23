using System.Collections;
using TMPro;
using UnityEngine;

public class TypewriterEffect : MonoBehaviour
{
    public float typingSpeed = 0.05f; // Velocidade da digitação
    public TextMeshProUGUI textComponent;

    private void Start()
    {
        textComponent.text = ""; // Inicia o texto como vazio
    }

    public void RunTypewriter(string text)
    {
        StopAllCoroutines(); // Para qualquer digitação em andamento
        StartCoroutine(TypeText(text)); // Começa o efeito de digitação
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
