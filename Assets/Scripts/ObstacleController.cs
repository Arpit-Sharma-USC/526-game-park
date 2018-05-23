using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

    private GameObject gameControllerObject;
    private GameController gameController; 

	// Use this for initialization
	void Start () {
        gameControllerObject = GameObject.Find("GameController");
        gameController = gameControllerObject.GetComponent<GameController>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        // If the play runs into an obstacle, game over
        if (col.gameObject.tag == "Player")
        {
            gameController.GameOver();
        }
    }
}
