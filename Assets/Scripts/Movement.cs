using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody rb;
    public Vector3 velocity = new Vector3(0,0,10);
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
