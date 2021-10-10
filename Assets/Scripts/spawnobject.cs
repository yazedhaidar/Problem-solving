using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
    public GameObject box;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        Spawn();
        //InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    private void Update()
    {
        
        
    }

    void Spawn()
    {
        Vector3 BoxPosition = new Vector3(Random.Range(-24f, 24f), Random.Range(-7f, 7f), 0f);

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        
          
            //Memduplikasi enemy
            Instantiate(box, BoxPosition, spawnPoints[spawnPointIndex].rotation);
        
        

       
    }

}
