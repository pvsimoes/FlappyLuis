using UnityEngine;
using System.Collections;

public class ObstaclesMovement : MonoBehaviour {

	public Vector2 obstacleVelocity = new Vector2 (-4, 0);
	public float randomness = 4;

	void Start() {
		GetComponent<Rigidbody2D> ().velocity = obstacleVelocity;
		transform.position = new Vector3 (transform.position.x, transform.position.y - randomness * Random.value, transform.position.z);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
