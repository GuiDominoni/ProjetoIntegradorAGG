using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoNiveis : MonoBehaviour
{
    public GameObject ImagemNv1, ImagemNv2, ImagemNv3, ImagemNv4, ImagemNv5, ImagemNv6, ImagemNv7,
        ImagemNv8, ImagemNv9, ImagemNv10, ImagemNv11, ImagemNv12, ImagemNv13, ImagemNv14, ImagemNv15, ImagemNv16, ImagemNv17,
        ImagemNv18, ImagemNv19, ImagemNv20, sairDaImagem1,  sairDaImagem2, sairDaImagem3, prox1, ant1, prox2, ant2, noveDezesseis, dezesseteVinte, umOito;

    public void n1()
    {
            
            ImagemNv1.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
    }
    public void n2()
    {
        if (GlobalVariaveis.n2 == 1)
        {
            ImagemNv2.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n3()
    {
        if (GlobalVariaveis.n3 == 1)
        {
            ImagemNv3.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n4()
    {
        if (GlobalVariaveis.n4 == 1)
        {
            ImagemNv4.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n5()
    {
        if (GlobalVariaveis.n5 == 1)
        {
            ImagemNv5.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n6()
    {
        if (GlobalVariaveis.n6 == 1)
        {
            ImagemNv6.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n7()
    {
        if (GlobalVariaveis.n7 == 1)
        {
            ImagemNv7.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n8()
    {
        if (GlobalVariaveis.n8 == 1)
        {
            ImagemNv8.SetActive(true);
            sairDaImagem1.SetActive(true);
            prox1.SetActive(false);
        }
    }
    public void n9()
    {
        if (GlobalVariaveis.n9 == 1)
        {
            ImagemNv9.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n10()
    {
        if (GlobalVariaveis.n10 == 1)
        {
            ImagemNv10.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n11()
    {
        if (GlobalVariaveis.n11 == 1)
        {
            ImagemNv11.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n12()
    {
        if (GlobalVariaveis.n12 == 1)
        {
            ImagemNv12.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n13()
    {
        if (GlobalVariaveis.n13 == 1)
        {
            ImagemNv13.SetActive(true);
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
            ImagemNv14.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n15()
    {
        if (GlobalVariaveis.n15 == 1)
        {
            ImagemNv15.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
    }
    public void n16()
    {
        if (GlobalVariaveis.n16 == 1)
        {
            ImagemNv16.SetActive(true);
            sairDaImagem2.SetActive(true);
            prox2.SetActive(false);
            ant1.SetActive(false);
        }
       
    }
    public void n17()
    {
        if (GlobalVariaveis.n17 == 1)
        {
            ImagemNv17.SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n18()
    {
        if (GlobalVariaveis.n18 == 1)
        {
            ImagemNv18.SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n19()
    {
        if (GlobalVariaveis.n19 == 1)
        {
            ImagemNv19.SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void n20()
    {
        if (GlobalVariaveis.n20 == 1)
        {
            ImagemNv20.SetActive(true);
            sairDaImagem3.SetActive(true);
            ant2.SetActive(false);
        }
    }
    public void sair1()
    {
        ImagemNv1.SetActive(false);
        ImagemNv2.SetActive(false);
        ImagemNv3.SetActive(false);
        ImagemNv4.SetActive(false);
        ImagemNv5.SetActive(false);
        ImagemNv6.SetActive(false);
        ImagemNv7.SetActive(false);
        ImagemNv8.SetActive(false);

        prox1.SetActive(true);
        sairDaImagem1.SetActive(false);

    }
    public void sair2()
    {
        ImagemNv9.SetActive(false);
        ImagemNv10.SetActive(false);
        ImagemNv11.SetActive(false);
        ImagemNv12.SetActive(false);
        ImagemNv13.SetActive(false);
        ImagemNv14.SetActive(false);
        ImagemNv15.SetActive(false);
        ImagemNv16.SetActive(false);
        sairDaImagem2.SetActive(false);
        prox2.SetActive(true);
        ant1.SetActive(true);
    }
    public void sair3()
    {
        ImagemNv17.SetActive(false);
        ImagemNv18.SetActive(false);
        ImagemNv19.SetActive(false);
        ImagemNv20.SetActive(false);
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



}
public static class GlobalVariaveis
{


    public static int n1, n2, n3, n4, n5, n6, n7, n8, n9,
        n10, n11, n12, n13, n14 = 1, n15, n16, n17, n18 = 1, n19, n20;


}
