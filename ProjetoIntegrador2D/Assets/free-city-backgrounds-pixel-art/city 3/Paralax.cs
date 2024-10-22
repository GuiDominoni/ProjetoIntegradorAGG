using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    private float length;
    private float startPos;
    public float parallaxSpeed; // Velocidade do movimento
    private Transform cam;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform; // Para obter a posição da câmera se necessário
    }

    void Update()
    {
        // Faz o fundo se mover continuamente
        float distance = parallaxSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);

        // Reposiciona o fundo quando ele sai da tela
        if (transform.position.x > startPos + length)
        {
            transform.position = new Vector3(startPos - length, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < startPos - length)
        {
            transform.position = new Vector3(startPos + length, transform.position.y, transform.position.z);
        }
    }
}
