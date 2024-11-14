
using UnityEngine;

public class RandomizarSpawn : MonoBehaviour
{
    public GameObject[] itens, spawn;
    // Start is called before the first frame update
    void Start()
    {
        int QualVaiSer = 0;
        for (int x = 0; x < itens.Length; x++)
        {
            int RandomNumero1 = Random.Range(0, spawn.Length);


            if (itens[QualVaiSer] != null && spawn[RandomNumero1] != null) 
            {
                itens[QualVaiSer].transform.position = spawn[RandomNumero1].transform.position;
                spawn[RandomNumero1] = null;
            }
            
            if(spawn[RandomNumero1] == null)
            {

                comeco:
                if (spawn[RandomNumero1] == null)
                {
                    RandomNumero1 = Random.Range(0, spawn.Length);
                    

                    if (spawn[RandomNumero1] == null) 
                    {
                        
                        goto comeco;
                    }
                    else
                    {

                        itens[QualVaiSer].transform.position = spawn[RandomNumero1].transform.position; 
                    }

                }
                spawn[RandomNumero1] = null;


            }
            QualVaiSer++;
        }





    }

    
    void Update()
    {
        

    }
}
