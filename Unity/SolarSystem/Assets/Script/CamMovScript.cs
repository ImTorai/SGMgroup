using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchScript.Gestures;
using System;

public class CamMovScript : MonoBehaviour
{

    public ScreenTransformGesture TwoFingerMoveGesture;
    public ScreenTransformGesture ManipulationGesture;
    public float PanSpeed = 200f;
    public float RotationSpeed = 200f;
    public float ZoomSpeed = 10f;

    private Transform cam;


    void Start()
    {
        Application.runInBackground = true;
    }

    private void Awake()
    {
        cam = Camera.main.transform;
    }


    void Update()
    {


    }


    private void OnEnable()
    {
      
    }

    private void manipulationTransformedHandler(object sender, EventArgs e)
    {
      
        
    }

    private void OnDisable()
    {
       

    }




}
