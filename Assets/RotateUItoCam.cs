using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUItoCam : MonoBehaviour {

    public GameObject hmd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 cameraPosition = hmd.transform.position;
        cameraPosition.y = transform.position.y;
        transform.LookAt(cameraPosition);
	}
}
