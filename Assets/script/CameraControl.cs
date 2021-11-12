using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public PlayerControl myPlayer;

    private Vector3 lastPlayerPosition;
    private float distanceMove;


    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<PlayerControl>();
        lastPlayerPosition = myPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceMove = myPlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceMove, transform.position.y, transform.position.z);

        lastPlayerPosition = myPlayer.transform.position;
    }
}
