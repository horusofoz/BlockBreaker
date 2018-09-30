using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

    // Config Parameters
    [Range(0.1f, 1.5f)] [SerializeField] float gameSpeed = 0.85f;

	// Use this for initialization
	void Start () 
	{
        Time.timeScale = gameSpeed;
    }
	
	// Update is called once per frame
	void Update () 
	{
        gameSpeed = Time.timeScale;
    }
}
