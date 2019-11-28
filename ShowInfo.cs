using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShowInfo : MonoBehaviour {

	public GameObject Info;
	private bool Show=false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowAndHide(){

		if (!Show) {
		
			Info.SetActive (true);
			float i;
			for (i = 0; i <= 4f; i += Time.deltaTime)
				;
			Show = true;
		} else {
			Info.SetActive (false);
			Show = false;
		}
	}

}
