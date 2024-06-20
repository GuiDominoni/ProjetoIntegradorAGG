using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorDoMouse : MonoBehaviour
{


    public float inputMouse;
    public GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        
        mouse.transform.position = Input.mousePosition; 



    }
}
