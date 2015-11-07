using UnityEngine;
using System.Collections;

public class LuisMovement : MonoBehaviour {

	public Vector2 jump = new Vector2(0, 100);

	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce(jump);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if(screenPosition.y > Screen.height || screenPosition.y < 0){
			Death();
		}
	
	}

	void OnCollisionEnter2D(Collision2D obstacle){
		Death ();
	}

	void Death (){
		Application.LoadLevel (Application.loadedLevel);
	}



}
