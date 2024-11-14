using UnityEngine;
using TMPro;
using System.Collections;


public class TypeWritterEffect : MonoBehaviour
{
    public TMP_Text uiText;  // O texto que vai aparecer
    public float typingSpeed = 0.05f;  // Velocidade da escrita

    private string baseText;  // Texto base que será exibido
    private Coroutine typingCoroutine;  // Referência à corrotina
    public GameObject aa;

    void Awake()
    {
      
        baseText = uiText.text;  
        uiText.text = ""; 
    }

    private void OnEnable()
    {
        RestartTyping(); 
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (aa != null)
            {
                aa.SetActive(false);
            }
          
            
        }
    }

    public void RestartTyping()
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine); 
        }
        uiText.text = ""; 
        typingCoroutine = StartCoroutine(ShowText());  
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < baseText.Length; i++)
        {
            uiText.text += baseText[i];  
            yield return new WaitForSeconds(typingSpeed);  
        }
    }
}
