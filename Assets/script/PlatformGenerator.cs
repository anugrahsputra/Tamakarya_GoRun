using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{

    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public ObjectPooler objectPool;
    public float randomCoinThreshold;

    private float platformWidth;
    private CoinGenerator coinGenerator;


    // Start is called before the first frame update
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        coinGenerator = FindObjectOfType<CoinGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < generationPoint.position.x){

            transform.position = new Vector3(transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

            // Instantiate (thePlatform, transform.position, transform.rotation);
            GameObject newPlatform = objectPool.GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);


            if(Random.Range(0f, 100f) < randomCoinThreshold){
                
                coinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 3f, transform.position.z));

            }

        }


    }
}
