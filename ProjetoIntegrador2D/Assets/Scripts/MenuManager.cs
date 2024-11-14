
using UnityEngine;

public class MenuManager : MonoBehaviour
{
   public GameObject menu;
    public GameObject opcao;
   public void opcoes()
   {
        menu.SetActive(false);
        opcao.SetActive(true);

   }
}
