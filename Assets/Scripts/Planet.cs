using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour {

    public float mass = 100f;
    private GameObject[] planets;
    private Rigidbody rb;
    private float gConst;
	// Use this for initialization
	void Start () {
        gConst = GameObject.Find("Constants").GetComponent<Constants>().gConst;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.mass = mass;
	}
	
	// Update is called once per frame
	void Update () {
        gConst = GameObject.Find("Constants").GetComponent<Constants>().gConst;
    }

    private void FixedUpdate()
    {
        planets = GameObject.FindGameObjectsWithTag("Planet");
        foreach(GameObject planet in planets)
        {
            if (planet != gameObject)
            {
                float distance = Vector3.Distance(planet.transform.position, transform.position);
                Vector3 planetDirection = (planet.transform.position - transform.position).normalized;
                float pMass = planet.GetComponent<Planet>().mass;
                Vector3 acceleration = Time.fixedDeltaTime * gConst * planetDirection * pMass * mass / (Mathf.Pow(distance, 2));
                rb.AddForce(acceleration);
            }
        }
    }
}
