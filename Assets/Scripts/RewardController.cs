using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardController : MonoBehaviour {
    private GameObject gameControllerObject;
    private GameController gameController;

    // Use this for initialization
    void Start () {
        gameControllerObject = GameObject.Find("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(3, 3, 3)); 
	}

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("OnTriggerEnter()");
        Debug.Log(col.gameObject.tag);

        if (col.gameObject.tag == "Player")
        {
            gameController.ChangeScore(1); 
            Destroy(gameObject);
        }
    }
}
