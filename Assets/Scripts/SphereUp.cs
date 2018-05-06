using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereUp : MonoBehaviour {

    private Rigidbody rb;
    private bool movingForward;
    private bool movingBack;
    private bool movingLeft;
    private bool movingRight;

	// Use this for initialization
	void Awake () {
        Debug.Log("Hello, sphere.");
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        getMovement();



		
	}

	void FixedUpdate() {
        if( movingForward ) {
            rb.AddForce(Vector3.forward * 600f * Time.deltaTime);   
        } else if( movingBack ) {
            rb.AddForce(Vector3.back * 600f * Time.deltaTime);
        } else if( movingLeft ) {
            rb.AddForce(Vector3.left * 600f * Time.deltaTime);
        } else {
            rb.AddForce(Vector3.right * 600f * Time.deltaTime);
        }


	}

    void getMovement() {
        var verticalAxis = Input.GetAxis("Vertical");
        var horizontalAxis = Input.GetAxis("Horizontal");

        movingForward = verticalAxis > 0;
        movingBack = verticalAxis < 0;

        movingLeft = horizontalAxis < 0;
        movingRight = horizontalAxis > 0;

    }
}
