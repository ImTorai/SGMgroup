using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;
using System;

public class CamMovScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Application.runInBackground = true;	
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}


    private void OnEnable()
    {
        GetComponent<PressGesture>().Pressed += onPressed; 
    }

    private void OnDisable()
    {
        GetComponent<PressGesture>().Pressed -= onPressed;
    }



    void onPressed(object s, EventArgs a)
    {
        Debug.Log("PRESSED");
    }

}
