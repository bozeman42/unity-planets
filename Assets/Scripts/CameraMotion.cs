using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Mouse X");
        // tranform.position = (transform.parent.position - transform.position) * Quaternion.FromToRotation(transform.forward, transform.up * rotation);
        transform.Rotate(transform.up * rotation);
	}
}
