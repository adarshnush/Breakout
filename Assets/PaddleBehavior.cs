using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour {
    public KeyCode keyLeft = KeyCode.LeftArrow;
    public KeyCode keyRight = KeyCode.RightArrow;
    public int paddleSpeed = 5;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if (Input.GetKey (keyRight) && pos.x < 5.7)
        {
            pos.x += paddleSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(keyLeft) && pos.x < 5.7)
        {
            pos.x -= paddleSpeed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
