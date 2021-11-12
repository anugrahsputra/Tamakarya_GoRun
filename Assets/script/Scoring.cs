using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    public Text scoreText;
    
    public float scoreCount;

    public bool scoreIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ": " + Mathf.Round(scoreCount);
    }

    public void AddScore(int addPoin){
        scoreCount += addPoin;
    }
}
