using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereUp : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Awake () {
        Debug.Log("Hello, sphere.");
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(Vector3.up * 600f * Time.deltaTime);
		
	}
}
