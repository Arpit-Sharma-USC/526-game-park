using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameController : MonoBehaviour {
    public GameObject gameOverCanvas;
    public Text scoreText;
    public int score;

    // Public GameObjects to dynamically create prefabs
    public GameObject floorPrefab;
    public GameObject rewardCubePrefab;
    public GameObject obstacleCubePrefab; 

    // Player object (ball)
    private GameObject player;

    // How far along the x-axis the floor is created 
    private float floorCreatedDistance; 

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player"); 

        CreateFloor(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (GetPlayerPosition() + 50 > floorCreatedDistance) {
            CreateFloor();
            CreateObstacles();
            CreateRewards();
        }
	}

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    // Update score
    public void ChangeScore(int changeAmount)
    {
        score += changeAmount;

        // Update score display in screen
        scoreText.text = score.ToString(); 
    }

    // Dynamically create floor prefabs
    public void CreateFloor()
    {
        // Get current player's x position 
        float playerXPos = GetPlayerPosition();

        GameObject floorInstance = Instantiate(floorPrefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

        // Get the mesh object of floor instnace
        Mesh mesh = floorInstance.GetComponent<MeshFilter>().mesh;

        // To calculate the size of the plane, multiply the original size (10x0x10) by scale vector
        Vector3 newFloorSize = Vector3.Scale(mesh.bounds.size, floorInstance.transform.localScale);

        // Move the floor object
        floorInstance.transform.Translate(new Vector3(newFloorSize.x / 2 + floorCreatedDistance, 0, 0));

        // Update floor distance
        floorCreatedDistance += newFloorSize.x;
    }

    // Dynamically create obstacles
    public void CreateObstacles()
    {
    }

    // Dynamically create rewards
    public void CreateRewards()
    {
        
    }

    // Get x position of player
    public float GetPlayerPosition()
    {
        return player.transform.position.x; 
    }
}
