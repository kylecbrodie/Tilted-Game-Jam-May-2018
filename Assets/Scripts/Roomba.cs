using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roomba : MonoBehaviour {

    private Rigidbody roomba;
    private bool rotate;
    private bool move;
    private float currentRads;
    private int counter;

	// Use this for initialization
	void Start () {
        move = true;
        rotate = false;
        counter = 0;
	}

	private void Awake() {
        roomba = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
        if (rotate) {
            RoombaRotate();
        }
	}

	void FixedUpdate() {
        if( move ) {
            RoombaMove();     
        }
	}

	void OnCollisionEnter(Collision collision) {
        Debug.Log("hello");
        move = false;
        rotate = true;
	}

    void RoombaRotate() {
        //roomba.AddForce(Vector3.forward * 0 * Time.deltaTime);
        transform.Rotate(Vector3.forward * 60 * Time.deltaTime, Space.Self);
    }

    void RoombaMove() {
        roomba.AddForce(Vector3.forward * 350f * Time.deltaTime);
    }
}
