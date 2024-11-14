
using UnityEngine;
using UnityEngine.UI;

public class Inveta : MonoBehaviour
{
    public Text textoMadeira;

    private void Update()
    {
        textoMadeira.text = MadeirasQueEuTenho.Madeiras + "x";
    }
}
