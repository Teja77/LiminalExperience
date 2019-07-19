using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float hori = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		controller (hori, vert);
	}
	void controller (float x,float y)
	{
		transform.position += new Vector3 (x, 0.0f, y);
	}
}