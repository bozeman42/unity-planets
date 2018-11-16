using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour {

    /// <summary>
    /// Not currently in use. Was working on how to keep all planets in view. Will try again another time.
    /// </summary>
    /// 

    // Use this for initialization
    private GameObject[] planets;

	void Start () {
        planets = GameObject.FindGameObjectsWithTag("Planet");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 center = getCenter(planets);
        transform.rotation = transform.rotation * Quaternion.FromToRotation(transform.forward, (center - transform.position).normalized);
	}

    private Vector3 getCenter(GameObject[] planets)
    {
        Vector3 posSum = new Vector3(0, 0, 0);
        foreach (GameObject planet in planets)
        {
            posSum += planet.transform.position;
        }
        return posSum / planets.Length;
    }
}
