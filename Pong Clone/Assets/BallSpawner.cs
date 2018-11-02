using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ball;

    GameObject clone;

	void Start () {
        SpawnBall();
	}
	

    public void SpawnBall()
    {
        clone = Instantiate(ball, new Vector2(0, 2), Quaternion.identity);
    }
}
