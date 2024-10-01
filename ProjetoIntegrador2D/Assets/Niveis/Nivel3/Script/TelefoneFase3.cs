using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TelefoneFase3 : MonoBehaviour
{
    public GameObject tudo, textoAviso, fundoFala, textoConversaGO, eletricista;
    public TMP_Text textoTxt, textoConversa;
    public int quantosTem;
    public string texto;
    public bool podeLigar, falaAtivada, podeclic = true;
    public int NumeroQueVaiSer, emQFalaEstou;
    PortaFase3 porta;
    bool chameiSegundaFala;
    

    // Start is called before the first frame update
    void Start()
    {
        texto = "";
        NumeroQueVaiSer = Random.Range(1000, 10000);
        GlobalVariaveis.emQueNivelEstou = 3;
        porta = FindObjectOfType<PortaFase3>();
    }

    // Update is called once per frame
    void Update()
    {
        textoTxt.text = texto;
        if (quantosTem == 4 && texto != NumeroQueVaiSer.ToString())
        {
            StartCoroutine(limpar());

        }
        if (quantosTem == 4 && texto == NumeroQueVaiSer.ToString() && podeLigar)
        {
            StartCoroutine(Acertou());

        }
        if (quantosTem == 4 && texto == NumeroQueVaiSer.ToString() && !podeLigar)
        {
            StartCoroutine(limpar());

        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            AtivarTudo();
        
        }
        if (falaAtivada) { falas(); }
        if (chameiSegundaFala && Input.GetMouseButton(0))
        {

            fundoFala.SetActive(false);
            porta.podeAbrir = true;

        }
    }
    public void adicionarLetra(string Letra)
    {
        if (quantosTem < 4)
        {
            texto += Letra;
            quantosTem++;
        }

    }

    public void AtivarTudo()
    {
        if (!tudo.activeSelf)
        {
            tudo.SetActive(true);
            Cursor.visible = true;
            texto = "";
        }
        else
        {
            tudo.SetActive(false);
            Cursor.visible = false;
            texto = "";
        }
        quantosTem = 0;

    }
   
    IEnumerator limpar()
    {
      
        yield return new WaitForSeconds(0.6f);
        texto = "";
        quantosTem = 0;
        textoAviso.SetActive(true);
        yield return new WaitForSeconds(1);
        textoAviso.SetActive(false);

    }
    IEnumerator Acertou()
    {

        yield return new WaitForSeconds(1);
        tudo.SetActive(false);
        texto = "";
        quantosTem = 0;
        yield return new WaitForSeconds(1); 
        falaAtivada = true;
        

    }
    public void falas()
    {
        fundoFala.SetActive(true);
        if(emQFalaEstou == 0)
        {

            textoConversa.text = "Dr. Frank: Olá a luz aqui caiu e eu preciso muito da sua ajuda, estou na universidade ____.";
            
        }
        if (emQFalaEstou == 1)
        {

            textoConversa.text = "Eletricista: Estou a caminho, aguarde um instante.";
           
        }
        if(emQFalaEstou == 2)
        {
            falaAtivada = false;
            fundoFala.SetActive(false);
            textoConversaGO.SetActive(false);
            StartCoroutine(SegundaFala());
            podeLigar = false;

        }
        if (Input.GetMouseButton(0) && podeclic)
        {
            emQFalaEstou++;
            StartCoroutine(podeClicar());
        }



    }
    IEnumerator podeClicar()
    {
        podeclic = false;
        yield return new WaitForSeconds(1);
        podeclic = true;

    }
    IEnumerator SegundaFala()
    {
        chameiSegundaFala = true;
        yield return new WaitForSeconds(4);
        fundoFala.SetActive(true);
        textoConversaGO.SetActive(true);

        textoConversa.text = "Eletricista: Cheguei, preciso que venha aqui abrir a porta no primeiro andar.";
        eletricista.SetActive(true);
    }


}
