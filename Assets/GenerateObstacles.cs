using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

	public GameObject obstacles;



	// Use this for initialization
	void Start () {
		InvokeRepeating ("CreateObstacle", 2f, 3f);
	}
	
	// Update is called once per frame
	void CreateObstacle () {
		Instantiate (obstacles);
	}	

}
