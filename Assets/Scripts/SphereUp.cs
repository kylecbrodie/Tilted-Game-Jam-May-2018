using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello, sphere.");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.up * .1f * Time.deltaTime;
		
	}
}
