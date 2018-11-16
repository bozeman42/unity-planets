using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCameraTarget : MonoBehaviour {

    public GameObject cameraTarget;
    private GameObject[] planets;
    private List<GameObject> targetPlanets = new List<GameObject>();
    private int index;
	// Use this for initialization
	void Start () {
        planets = GameObject.FindGameObjectsWithTag("Planet");
        Debug.Log("Length: " + planets.Length);
        foreach (GameObject planet in planets)
        {
            if (planet.name != "Sun")
            {
                Debug.Log("Adding " + planet.name);
                targetPlanets.Add(planet);
            }
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = cameraTarget.transform.position;
        transform.Rotate(transform.up * Input.GetAxis("Mouse X"));
        if (Input.GetMouseButtonDown(0))
        {
            if (index < targetPlanets.Count - 1)
            {
                index++;
            } else
            {
                index = 0;
            }
            cameraTarget = targetPlanets[index];
        }
	}
}
