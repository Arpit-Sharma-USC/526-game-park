using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rigidbody;
    private bool isJumpInProgress; 
    public float forwardSpeed = 12.0f;
    public float sideSpeed = 0.15f; 
    public float jumpStrength = 5.0f;
    private GameObject gameControllerObject;
    private GameController gameController; 
    private int score;

	// Use this for initialization
	void Start () 
    {
        gameControllerObject = GameObject.Find("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();

        rigidbody = GetComponent<Rigidbody>();
        isJumpInProgress = false;
        score = 0; 
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Side movement
        float sideMovement = 0; 
        
        if (h > 0) sideMovement = -sideSpeed;
        else if (h < 0) sideMovement = sideSpeed; 
        
        // Forward movement
        Vector3 movement = new Vector3(forwardSpeed, 0, 0);
        rigidbody.AddForce(movement);

        // If the player is in the middle of a jump, the ball cannot move sideways or jump again
        if (!isJumpInProgress)
        {
            // Side movement (use transform.position instead of AddForce to avoid awkward velocity effects)
            transform.Translate(new Vector3(0, 0, sideMovement));

            // Jump
            if (v > 0)
            {
                isJumpInProgress = true;
                rigidbody.AddForce(new Vector3(0, jumpStrength, 0), ForceMode.Impulse);
            }
        }

        // If the ball falls below our threshold, game over
        if (transform.position.y < -1)
        {
            gameController.GameOver();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            isJumpInProgress = false; 
        }
        
        // If the ball runs into an obstacle, game over
        else if (col.gameObject.tag == "obstacle")
        {
            gameController.GameOver();
        }
    }
}
