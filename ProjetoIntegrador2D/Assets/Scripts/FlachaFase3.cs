using UnityEngine;

public class FlachaFase3 : MonoBehaviour
{
    public Transform player; 
    public Transform generator; 

    private void Update()
    {

       
        Vector3 direction = generator.position - player.position;

        
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);

       
        transform.position = player.position + direction.normalized * 1.5f; 
    }
}
