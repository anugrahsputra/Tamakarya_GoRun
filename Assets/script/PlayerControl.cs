using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    public float moveSpeed;
    public float speedMultiplier;
    public float speedIncreaseMilestone;

    private float speedMilestoneCount;

    public float jumpForce;

    private Rigidbody2D rigidBody;
    private Collider myCollider;

    public bool isGround;
    public LayerMask whatIsGround;

    public AudioSource jumpSound;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider>();

        speedMilestoneCount = speedIncreaseMilestone;
    }

    public void Jump(){
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
        jumpSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > speedMilestoneCount){
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone = speedIncreaseMilestone * speedMultiplier;
            moveSpeed = moveSpeed * speedMultiplier;
        }
        rigidBody.velocity = new Vector2(moveSpeed, rigidBody.velocity.y);
    }
}
