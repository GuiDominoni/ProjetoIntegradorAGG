using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PretoTelasFase3 : MonoBehaviour
{
    GameManagerFase3 gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerFase3>();
    }

    // Update is called once per frame
    void Update()
    {
        
        gameManager.possoAbrirTelefone = false;
    }
    private void OnDisable()
    {
        gameManager.possoAbrirTelefone = true;
    }
    
}
