using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController cc;
    float horizontal, vertical;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movimento();



    }

    void movimento()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 destino = new Vector2(horizontal, -1f);
        cc.Move(destino * speed * Time.deltaTime);

    }
}
