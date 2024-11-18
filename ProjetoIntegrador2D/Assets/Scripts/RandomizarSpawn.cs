
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomizarSpawn : MonoBehaviour
{
    public GameObject[] itens, spawn;
    List<GameObject> spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = spawn.ToList();
        for (int x = 0; x < itens.Length; x++)
        {
            int RandomNumero1 = Random.Range(0, spawnPoints.Count);


            if (itens[x] != null && spawn[RandomNumero1] != null) 
            {
                itens[x].transform.position = spawnPoints[RandomNumero1].transform.position;
                spawnPoints.RemoveAt(RandomNumero1);
              

            }
        }
    }

}
