using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    // Config Parameters
    [Range(0.1f, 1.5f)] [SerializeField] float gameSpeed = 0.85f;
    [SerializeField] int pointsPerBlockDestroyed = 50;

    // State Variables
    [SerializeField] int currentScore = 0;
	
	// Update is called once per frame
	void Update () 
	{
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
