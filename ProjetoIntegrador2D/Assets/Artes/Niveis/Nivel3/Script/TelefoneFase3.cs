using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TelefoneFase3 : MonoBehaviour
{

    [Header("Objetos")]

    public GameObject celularInteiro;
    public GameObject textoAviso, textoAviso2, fundoFala, textoConversaGO, eletricista;

    [Space]

    [Header("Textos")]
    public TMP_Text textoTxt;
    public TMP_Text textoConversa, textoCartaz;


    string _texto;
    [HideInInspector] public bool podeLigar;
    bool _falaAtivada, _podeclic = true;
    int _numeroQueVaiSer, _emQFalaEstou, _quantosNumerosTem;
    PortaFase3 porta;
    bool _chameiSegundaFala;
    GameManagerFase3 gameManagerFase3;

    // Start is called before the first frame update
    void Start()
    {
        _texto = "";
        _numeroQueVaiSer = Random.Range(1000, 10000);
        textoCartaz.text = _numeroQueVaiSer.ToString();
        _podeclic = true;
        GlobalVariaveis.emQueNivelEstou = 3;
        porta = FindObjectOfType<PortaFase3>();
        gameManagerFase3 = FindObjectOfType<GameManagerFase3>();
    }

    // Update is called once per frame
    void Update()
    {
       
        textoTxt.text = _texto;


        if (_quantosNumerosTem == 4)
        {
            if (_texto == _numeroQueVaiSer.ToString())
            {

                if (podeLigar)
                {
                    StartCoroutine(Acertou());

                }
                else
                {
                    StartCoroutine(limpar2());

                }

            }
            else
            {

                StartCoroutine(limpar());

            }

        }




        if (Input.GetKeyDown(KeyCode.Space) && gameManagerFase3.possoAbrirTelefone) 
        {
            AtivarTudo();
            
        
        }
        if (_falaAtivada) { falas(); }
        if (_chameiSegundaFala && Input.GetMouseButton(0))
        {

            fundoFala.SetActive(false);
            porta.podeAbrir = true;

        }
    }
    public void adicionarLetra(string Letra)
    {
        if (_quantosNumerosTem < 4)
        {
            _texto += Letra;
            _quantosNumerosTem++;
        }

    }

    public void AtivarTudo()
    {
        if (celularInteiro.activeSelf)
        {
            celularInteiro.SetActive(false);
         
            _texto = "";
            gameManagerFase3.possoPegarItem = true;
            gameManagerFase3.possoAbrirCartaz = true;
            inv.possoPegarOItem = true;
            
        }
        else
        {
            celularInteiro.SetActive(true);
          
            _texto = "";
            gameManagerFase3.possoPegarItem = false;
            gameManagerFase3.possoAbrirCartaz = false;
            inv.possoPegarOItem = false;
           
        }
        _quantosNumerosTem = 0;

    }
   
   
    public void falas()
    {
        fundoFala.SetActive(true);
        if(_emQFalaEstou == 0)
        {

            textoConversa.text = "Dr. Frank: Olá a luz aqui caiu e eu preciso muito da sua ajuda, estou na universidade ____.";
            
        }
        if (_emQFalaEstou == 1)
        {

            textoConversa.text = "Eletricista: Estou a caminho, aguarde um instante.";
           
        }
        if(_emQFalaEstou == 2)
        {
            _falaAtivada = false;
            fundoFala.SetActive(false);
            textoConversaGO.SetActive(false);
            StartCoroutine(SegundaFala());
            podeLigar = false;

        }
        if (Input.GetMouseButton(0) && _podeclic)
        {
            _emQFalaEstou++;
            StartCoroutine(podeClicar());
        }



    }   
    

    #region Corroutinas
 IEnumerator limpar()
    {
      
        yield return new WaitForSeconds(0.6f);
        _texto = "";
        _quantosNumerosTem = 0;
        textoAviso.SetActive(true);
        yield return new WaitForSeconds(1);
        textoAviso.SetActive(false);

    }
    IEnumerator limpar2()
    {

        yield return new WaitForSeconds(0.6f);
        _texto = "";
        _quantosNumerosTem = 0;
        textoAviso2.SetActive(true);
        yield return new WaitForSeconds(1);
        textoAviso2.SetActive(false);

    }
    IEnumerator Acertou()
    {

        yield return new WaitForSeconds(1);
        celularInteiro.SetActive(false);
        _texto = "";
        _quantosNumerosTem = 0;
        yield return new WaitForSeconds(1); 
        _falaAtivada = true;
        

    }
    
    IEnumerator podeClicar()
    {
        _podeclic = false;
        yield return new WaitForSeconds(1);
        _podeclic = true;

    }
    IEnumerator SegundaFala()
    {
        _chameiSegundaFala = true;
        yield return new WaitForSeconds(4);
        fundoFala.SetActive(true);
        textoConversaGO.SetActive(true);

        textoConversa.text = "Eletricista: Cheguei, preciso que venha aqui abrir a porta no primeiro andar.";
        eletricista.SetActive(true);
    }
    #endregion

}
