using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roombah : MonoBehaviour {

    private Rigidbody roomba;

	// Use this for initialization
	void Start () {
		
	}

	private void Awake()
	{
        roomba = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

        roomba.AddForce(Vector3.forward * 1000f * Time.deltaTime);
		
	}
}
