using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
        GameSession gameSession = GetComponent<GameSession>();
        gameSession.SetFinalScore();
	}
}
