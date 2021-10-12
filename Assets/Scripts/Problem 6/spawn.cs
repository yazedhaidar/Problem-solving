using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] box;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
    private int count = 0;

    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        
        Spawn();
       
    }
     void Update()
    {
        
        if(count<=3)
        {
            Spawn();
            count += 1;
        }
    }

    void Spawn()
    {
        Vector3 BoxPosition = new Vector3(Random.Range(-14f, 14f), Random.Range(-6.5f, 6.5f), 0f);

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex = Random.Range(0, box.Length);

        //Memduplikasi enemy
        Instantiate(box[randomIndex], BoxPosition, spawnPoints[spawnPointIndex].rotation);
    }
}
