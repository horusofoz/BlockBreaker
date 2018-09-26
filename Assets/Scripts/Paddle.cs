using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float ScreenWidthInUnits = 16f;
    [SerializeField] float minX = 0.7f;
    [SerializeField] float maxX = 15.3f;

    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        float mousePosInUnits = (Input.mousePosition.x / Screen.width * ScreenWidthInUnits);
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        Debug.Log(paddlePos.x);
        transform.position = paddlePos;
	}
}
