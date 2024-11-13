
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecaoNiveis : MonoBehaviour
{
    public GameObject  sairDaImagem1,  sairDaImagem2, sairDaImagem3, prox1, ant1, prox2, ant2, noveDezesseis, dezesseteVinte, umOito, preto, outroPreto;
    public GameObject[] ImagemNv, checkList, pretos;
    public GameObject[] comecar, Casos;
    public GameObject pretoAparecer, pretoDesaparecer;
    //Professor alexandre me desculpa, no inicio do ano eu fiz esse codigo, na segunda semana de pi e eu achava mais facil começar um array pelo indice 1 e nao 0, foi mau mas eu compreendo meu erro
    private void Start()
    {
        cutcene.cut = 1;
        Invoke("pretoDestivar", 1f);
        inv.i11 = false;
        inv.i12 = false;
        inv.i13 = false;
        inv.i14 = false;
        inv.i21 = false;
        inv.i22 = false;
        inv.i23 = false;
        inv.i24 = false;
        inv.i31 = false;
        inv.i32 = false;
        inv.i33 = false;
        inv.i34 = false;
        inv.i41 = false;
        inv.i42 = false;
        inv.i43 = false;
        inv.i44 = false;
        inv.i51 = false;
        inv.i52 = false;
        inv.i53 = false;
        inv.i54 = false;
        inv.i61 = false;
        inv.i62 = false;
        inv.i63 = false;
        inv.i64 = false;
        inv.i71 = false;
        inv.i72 = false;
        inv.i73 = false;
        inv.i74 = false;
        inv.i81 = false;
        inv.i82 = false;
        inv.i83 = false;
        inv.i84 = false;
        inv.i91 = false;
        inv.i92 = false;
        inv.i93 = false;    
        inv.i94 = false;
        inv.i101 = false;
        inv.i102 = false;   
        inv.i103 = false;
        inv.i104 = false;
        GlobalVariaveis.emQueNivelEstou = 0;
        if (GlobalVariaveis.Venci1)
        {
            checkList[0].SetActive(true);
            for(int i = 0; i < pretos.Length; i++)
            {
                pretos[i].SetActive(false);
                


            }

        }
        if (GlobalVariaveis.Venci2)
        {
            checkList[1].SetActive(true);


        }
        if (GlobalVariaveis.Venci3)
        {

            checkList[2].SetActive(true);

        }
        if (GlobalVariaveis.venci4)
        {

            checkList[3].SetActive(true);

        }



    }
    void Update()
    {


      


    }
    
    public void n1()
    {
        ImagemNv[0].SetActive(true);
        comecar[0].SetActive(true);
        sairDaImagem1.SetActive(true);
        prox1.SetActive(false);
        MudarEstadoTodos(false);
    }
    public void n2()
    {
       
            ImagemNv[1].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
            comecar[1].SetActive
                (true);
        MudarEstadoTodos(false);


    }
    public void n3()
    {
           ImagemNv[2].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
            comecar[2].SetActive (true);
        MudarEstadoTodos(false);
    }
    public void n4()
    {
        
            ImagemNv[3].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        MudarEstadoTodos(false);
    }
    #region  funcoes desnecessarias
    public void n5()
    {
        if (GlobalVariaveis.n5 == 1)
        {
            ImagemNv[4].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n6()
    {
        if (GlobalVariaveis.n6 == 1)
        {
            ImagemNv[5].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n7()
    {
        if (GlobalVariaveis.n7 == 1)
        {
            ImagemNv[6].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n8()
    {
        if (GlobalVariaveis.n8 == 1)
        {
            ImagemNv[7].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n9()
    {
        if (GlobalVariaveis.n9 == 1)
        {
            ImagemNv[8].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n10()
    {
        if (GlobalVariaveis.n10 == 1)
        {
            ImagemNv[9].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n11()
    {
        if (GlobalVariaveis.n11 == 1)
        {
            ImagemNv[10].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n12()
    {
        if (GlobalVariaveis.n12 == 1)
        {
            ImagemNv[11].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n13()
    {
        if (GlobalVariaveis.n13 == 1)
        {
            ImagemNv[12].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n14()
    {
        if (GlobalVariaveis.n14 == 1)
        {
            
            sairDaImagem2.SetActive(true);
            ImagemNv[13].SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n15()
    {
        if (GlobalVariaveis.n15 == 1)
        {
            ImagemNv[14].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n16()
    {
        if (GlobalVariaveis.n16 == 1)
        {
            ImagemNv[15].SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
       
    }
    public void n17()
    {
        if (GlobalVariaveis.n17 == 1)
        {
            ImagemNv[16].SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n18()
    {
        if (GlobalVariaveis.n18 == 1)
        {
            ImagemNv[17].SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n19()
    {
        if (GlobalVariaveis.n19 == 1)
        {
            ImagemNv[18].SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n20()
    {
        if (GlobalVariaveis.n20 == 1)
        {
            ImagemNv[19].SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    #endregion
    public void sair1()
    {
        ImagemNv[0].SetActive(false);
        ImagemNv[1].SetActive(false);
        ImagemNv[2].SetActive(false);
        ImagemNv[3].SetActive(false);
        
        comecar[0].SetActive(false) ;
        comecar[1].SetActive(false);
        comecar[2].SetActive(false);
        sairDaImagem1.SetActive(false);
        MudarEstadoTodos(true);

    }
    public void sair2()
    {
        ImagemNv[6].SetActive(false);
        ImagemNv[9].SetActive(false);
        ImagemNv[10].SetActive(false);
        ImagemNv[11].SetActive(false);
        ImagemNv[12].SetActive(false);
        ImagemNv[13].SetActive(false);
        ImagemNv[14].SetActive(false);
        ImagemNv[15].SetActive(false);
        sairDaImagem2.SetActive(false);
        
    }
    public void sair3()
    {
        ImagemNv[16].SetActive(false);
        ImagemNv[17].SetActive(false);
        ImagemNv[18].SetActive(false);
        ImagemNv[19].SetActive(false);
        sairDaImagem3.SetActive(false);
        ant2.SetActive(false);
        ant2.SetActive(true);
    }
    public void ProxPag1()
    {
        prox1.SetActive(false);
        prox2.SetActive(true);
        ant1.SetActive(true);
        umOito.SetActive(false);
        noveDezesseis.SetActive(true);


    }
    public void ProxPag2()
    {
        noveDezesseis.SetActive(false);
        dezesseteVinte.SetActive(true);
        prox2.SetActive(false);
        ant1.SetActive(false);
        ant2.SetActive(true);
            
    
    }
    public void PagAnt1()
    {
        noveDezesseis.SetActive(false);
        umOito.SetActive(true);
        prox1.SetActive(true);
        prox2.SetActive(false);
        ant1.SetActive(false);   
        
    }
    public void PagAnt2()
    {
        dezesseteVinte.SetActive(false);
        prox2.SetActive(true);
        ant1.SetActive(true);
        ant2.SetActive(false);
        noveDezesseis.SetActive(true);


    }
    public void comecarNv1()
    {
       
        StartCoroutine(MudarCena("Fase1Tutorial"));
        GlobalVariaveis.emQueNivelEstou = 1;
    }
    public void comecarNv2()
    {
        StartCoroutine(MudarCena("Fase2"));
        GlobalVariaveis.emQueNivelEstou = 2;
    }
    public void comecarNv3() {

        StartCoroutine(MudarCena("Fase3"));
    
        GlobalVariaveis.emQueNivelEstou = 3;
    }
    public void comecarNv4()
    {

        StartCoroutine(MudarCena("Fase4"));
        GlobalVariaveis.emQueNivelEstou = 4;
    }
    void pretoDestivar()
    {
        preto.SetActive(false);


    }
    public void menuPrincipal()
    {
        outroPreto.SetActive(true);
        Invoke("MainMenuCarregar", 0.4f);


    }
    public void MainMenuCarregar()
    {
        SceneManager.LoadScene("MainMenu");

    }
    public void MudarEstadoTodos(bool qualEstado)
    {
        for (int i = 0; i < Casos.Length; i++) 
        {
            Casos[i].SetActive(qualEstado);

        }

    }
    IEnumerator MudarCena(string cena)
    {

        pretoAparecer.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(cena);
    }


}
public static class GlobalVariaveis
{


    public static int n1, n2, n3, n4, n5, n6, n7, n8, n9,
        n10, n11, n12, n13, n14
        
        ,n15, n16, n17, n18, n19, n20, tuto, emQueNivelEstou;
    public static bool Venci1, Venci2, Venci3, venci4;

}
