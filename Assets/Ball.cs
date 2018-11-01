using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D rb;
    public float ballSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(ballSpeed, ballSpeed / 5);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D other)
    {
       // rb.velocity /= 2;
        Debug.Log("Ball Collided!");
    }
}
