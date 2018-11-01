using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour {

    float yPos;
    public float paddleSpeed;
    bool paddleCollidingTop, paddleCollidingBottom;

	// Use this for initialization
	void Start () {
        yPos = transform.position.y;
        paddleCollidingTop = false;
        paddleCollidingBottom = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(this.name == "PaddleOne")
        {
            if (Input.GetKey(KeyCode.W) && !paddleCollidingTop)
            {
                yPos += paddleSpeed;
                transform.position = new Vector2(transform.position.x, yPos);
            }

            if (Input.GetKey(KeyCode.S) && !paddleCollidingBottom)
            {
                yPos -= paddleSpeed;
                transform.position = new Vector2(transform.position.x, yPos);
            }
        }
        
        if(this.name == "PaddleTwo")
        {
            if (Input.GetKey(KeyCode.UpArrow) && !paddleCollidingTop)
            {
                yPos += paddleSpeed;
                transform.position = new Vector2(transform.position.x, yPos);
            }

            if (Input.GetKey(KeyCode.DownArrow) && !paddleCollidingBottom)
            {
                yPos -= paddleSpeed;
                transform.position = new Vector2(transform.position.x, yPos);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "WallTop")
        {
            paddleCollidingTop = true;
        }
        else if(other.gameObject.tag == "WallBottom")
        {
            paddleCollidingBottom = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        paddleCollidingTop = false;
        paddleCollidingBottom = false;
    }
}
