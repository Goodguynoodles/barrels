using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    
    
    private float StartDeley = 2;
    private float repeatRate = 1f;
    public GameObject Obstacle;
    private float min = 2.95f;
    private float max = -11.18f;
    
    // Start is called before the first frame update
    void Start()  
    {
        InvokeRepeating("SpawnObstical", StartDeley, repeatRate);
    }
    
    void SpawnObstical()
    {
        Vector3 spawnPos = new Vector3(Random.Range(min,max),3.68f,-144.9427f);
        Instantiate(Obstacle, spawnPos, Obstacle.transform.rotation);
    }
}
