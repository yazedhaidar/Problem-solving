using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
    public GameObject[] box;
    public float spawnTime ;
    public Transform[] spawnPoints;
    float timer = 0f;

    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        Spawn();
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
        int randomIndex = Random.Range(0, box.Length);

        //Memduplikasi enemy
        Instantiate(box[randomIndex], BoxPosition, spawnPoints[spawnPointIndex].rotation);
    }

    public void SpawnAfterDestroy()
    {
        Vector3 BoxPosition = new Vector3(Random.Range(-24f, 24f), Random.Range(-7f, 7f), 0f);

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex = Random.Range(0, box.Length);

       
        Instantiate(box[randomIndex], BoxPosition, spawnPoints[spawnPointIndex].rotation);
        

    }

    public float Timer()
    {
       
        return timer;

    }

}
