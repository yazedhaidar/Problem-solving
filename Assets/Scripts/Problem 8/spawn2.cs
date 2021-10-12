using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2 : MonoBehaviour
{
    public GameObject[] box;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Start()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        Spawn();
        Spawn();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        Vector3 BoxPosition = new Vector3(Random.Range(-19f, 19f), Random.Range(-7f, 7f), 0f);

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int randomIndex = Random.Range(0, box.Length);

        //Memduplikasi enemy
        Instantiate(box[randomIndex], BoxPosition, spawnPoints[spawnPointIndex].rotation);
    }
}
