using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private spawnTime;

    
    void Update()
    {
        if(Time.time > spawntime)
        {
            Spawn();
            spawntime = Time.time + timeBetweenSpawn;
        }
    }

    
    void Spawn()
    {
        float randomX = randomX.Range(minX, maxX);
        float randomY = randomY.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0).transform.rotation);
    }
}
