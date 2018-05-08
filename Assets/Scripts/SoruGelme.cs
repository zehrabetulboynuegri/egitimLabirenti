using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoruGelme : MonoBehaviour {

	public GameObject panel;
	public GameObject küp;

	// Use this for initialization
	public void Start () { 
			panel.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag=="hedef") 
		{
			panel.gameObject.SetActive (true);
			Destroy (küp);
		}
	}
}
	