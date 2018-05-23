using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour {
    public GameObject portalOut;
    public GameObject player;
    private PlayerController playerController; 

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        playerController = player.GetComponent<PlayerController>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.transform.Translate(portalOut.transform.position.x - player.transform.position.x, 0, portalOut.transform.position.z - player.transform.position.z, Space.World); 
        }
    }
}
