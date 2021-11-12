using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoins : MonoBehaviour
{

    public int scoreValue;

    private Scoring scoreSystem;
    private AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = FindObjectOfType<Scoring>();
        coinSound = GameObject.Find("Coin").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "player"){

            scoreSystem.AddScore(scoreValue);

            gameObject.SetActive(false);

            coinSound.Play();
        }
    }
}
