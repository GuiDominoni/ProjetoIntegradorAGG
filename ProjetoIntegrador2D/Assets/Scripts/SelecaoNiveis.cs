using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelecaoNiveis : MonoBehaviour
{
    public GameObject  sairDaImagem1,  sairDaImagem2, sairDaImagem3, prox1, ant1, prox2, ant2, noveDezesseis, dezesseteVinte, umOito, preto;
    public GameObject[] ImagemNv;
    public GameObject[] comecar;

    //os ARRAYS sao essas coisas com [] no final, e sao mais facil para a organização,
    //ficou mais organizado no inspector fazendo assim, entao a imagemNv[i] o i vai ser igual ao número que está lá mais 1, ex: ImagemNv[1] é a imagem do nivel 2 
    private void Start()
    {
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



    }
    public void n1()
    {
        ImagemNv[0].SetActive(true);
        comecar[0].SetActive(true);
        sairDaImagem1.SetActive(true);
        prox1.SetActive(false);
    }
    public void n2()
    {
        if (GlobalVariaveis.n2 == 1)
        {
            ImagemNv[1].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n3()
    {
        if (GlobalVariaveis.n3 == 1)
        {
            ImagemNv[2].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n4()
    {
        if (GlobalVariaveis.n4 == 1)
        {
            ImagemNv[3].SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
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
    public void sair1()
    {
        ImagemNv[0].SetActive(false);
        ImagemNv[1].SetActive(false);
        ImagemNv[2].SetActive(false);
        ImagemNv[3].SetActive(false);
        ImagemNv[4].SetActive(false);
        ImagemNv[5].SetActive(false);
        ImagemNv[6].SetActive(false);
        ImagemNv[7].SetActive(false);
        comecar[0].SetActive(false) ;

        prox1.SetActive(true);
        sairDaImagem1.SetActive(false);

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
        prox2.SetActive(true);
        ant1.SetActive(true);
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
        SceneManager.LoadScene("Fase1Tutorial");

    }
    void pretoDestivar()
    {
        preto.SetActive(false);


    }



}
public static class GlobalVariaveis
{


    public static int n1, n2, n3, n4, n5, n6, n7, n8, n9,
        n10, n11, n12, n13, n14
        
        ,n15, n16, n17, n18, n19, n20;


}
