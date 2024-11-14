using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    public Transform target; 
    public float smoothSpeed = 0.125f;

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
