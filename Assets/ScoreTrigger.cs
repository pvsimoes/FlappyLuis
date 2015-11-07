using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D() {
		score++;
	}

	void OnGUI () 
	{
		GUI.color = Color.black;
		GUILayout.Label(" Score: " + score.ToString());
	}
}
