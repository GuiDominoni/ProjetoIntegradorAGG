using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneVerdadeira : MonoBehaviour
{

    public GameObject[] Textos;
    public GameObject prosseguir;
    public int emQualEsta;
    public bool podeClicar;
    // Start is called before the first frame update
    void Start()
    {
        podeClicar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && podeClicar) 
        {


            emQualEsta++;
          StartCoroutine(ResetarCooldownClick());
            Proximo();
        }
    }
   public void SairCutscene()
    {
        SceneManager.LoadScene("SelecaoNiveis");

    }
    public void Proximo()
    {
        if (emQualEsta < Textos.Length)
        {
            Textos[emQualEsta - 1].SetActive(false);
            Textos[emQualEsta].SetActive(true);
        }
        if(emQualEsta == Textos.Length -1) 
        {  
            prosseguir.SetActive(false);
        }

    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    IEnumerator ResetarCooldownClick()
    {
        podeClicar = false;
        yield return new WaitForSeconds(1);
        podeClicar = true;

    }
}
