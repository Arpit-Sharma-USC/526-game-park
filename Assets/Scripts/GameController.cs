using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameController : MonoBehaviour {
    public GameObject gameOverCanvas;
    public Text scoreText;
    public int score; 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    public void ChangeScore(int changeAmount)
    {
        score += changeAmount;

        scoreText.text = score.ToString(); 
    }
}
