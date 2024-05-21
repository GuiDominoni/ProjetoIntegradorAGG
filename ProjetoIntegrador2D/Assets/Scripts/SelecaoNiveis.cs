using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecaoNiveis : MonoBehaviour
{
    public GameObject ImagemNv1, ImagemNv2, ImagemNv3, ImagemNv4, ImagemNv5, ImagemNv6, ImagemNv7, ImagemNv8, sairDaImagem;
    public void n1()
    {
        
            ImagemNv1.SetActive(true);
            sairDaImagem.SetActive(true);
        
    }
    public void n2()
    {
        if (GlobalVariaveis.n2 == 1)
        {
            ImagemNv2.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n3()
    {
        if (GlobalVariaveis.n3 == 1)
        {
            ImagemNv3.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n4()
    {
        if (GlobalVariaveis.n4 == 1)
        {
            ImagemNv4.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n5()
    {
        if (GlobalVariaveis.n5 == 1)
        {
            ImagemNv5.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n6()
    {
        if (GlobalVariaveis.n6 == 1)
        {
            ImagemNv6.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n7()
    {
        if (GlobalVariaveis.n7 == 1)
        {
            ImagemNv7.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n8()
    {
        if (GlobalVariaveis.n8 == 1)
        {
            ImagemNv8.SetActive(true);
            sairDaImagem.SetActive(true);
        }
    }
    public void n9()
    {

    }
    public void n10()
    {

    }
    public void n11()
    {

    }
    public void n12()
    {

    }
    public void n13()
    {

    }
    public void n14()
    {

    }
    public void n15()
    {

    }
    public void n16()
    {

    }
    public void n17()
    {

    }
    public void n18()
    {

    }
    public void n19()
    {

    }
    public void n20()
    {

    }
    public void sair()
    {
        ImagemNv1.SetActive(false);
        ImagemNv2.SetActive(false);
        ImagemNv3.SetActive(false);
        ImagemNv4.SetActive(false);
        ImagemNv5.SetActive(false);
        ImagemNv6.SetActive(false);
        ImagemNv7.SetActive(false);
        ImagemNv8.SetActive(false);
        sairDaImagem.SetActive(false);



    }



}
public static class GlobalVariaveis
{


    public static int n1, n2, n3, n4, n5, n6, n7, n8, n9,
        n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20;


}
