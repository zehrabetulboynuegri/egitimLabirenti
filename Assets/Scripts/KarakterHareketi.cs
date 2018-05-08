using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareketi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Input.GetAxis("Vertical")/20,0,0);
		transform.Rotate (0,0,Input.GetAxis("Horizontal")*2);
	}



}
