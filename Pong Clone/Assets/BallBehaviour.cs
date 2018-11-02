using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public float speed;

    Rigidbody2D rb;
    BallSpawner spawner;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        spawner = Camera.main.GetComponent<BallSpawner>();
        rb.velocity = new Vector2(speed, speed);
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
        spawner.SpawnBall();
    }
}
