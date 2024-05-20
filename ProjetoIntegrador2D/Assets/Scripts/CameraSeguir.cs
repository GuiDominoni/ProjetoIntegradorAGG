using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform target; // O objeto que queremos seguir
    public float smoothSpeed = 0.125f; // A velocidade de suavização do movimento

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z); // A posição que queremos alcançar, mantendo a coordenada Z da câmera
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Interpolação linear para suavizar o movimento
            transform.position = smoothedPosition; // Atualiza a posição do objeto que está seguindo
        }
    }
}
