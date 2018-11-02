using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float moveSpeed;

    bool collidedTop, collidedBottom;

    void Start() {
        collidedTop = false;
        collidedBottom = false;
    }

	void Update () {
		if(this.name == "PaddleOne")
        {
            if (Input.GetKey(KeyCode.W) && !collidedTop)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
            }
            else if (Input.GetKey(KeyCode.S) && !collidedBottom)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
            }
        }
        else if(this.name == "PaddleTwo")
        {
            if (Input.GetKey(KeyCode.UpArrow) && !collidedTop)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed);
            }
            else if (Input.GetKey(KeyCode.DownArrow) && !collidedBottom)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "WallTop")
            collidedTop = true;
        else if (other.gameObject.tag == "WallBottom")
            collidedBottom = true;
    }

    void OnCollisionExit2D(Collision2D other)
    {
        collidedBottom = false;
        collidedTop = false;
    }
}
