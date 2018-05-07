using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private List<Rigidbody> bones;

    private int kickDir = 0;

	// Use this for initialization
	void Start () {
        bones = new List<Rigidbody>();
        var gameObjects = GameObject.FindGameObjectsWithTag("Ragdoll");
        for (var i = 0; i < gameObjects.Length; i++) {
            var rb = gameObjects[i].GetComponent<Rigidbody>();
            if( rb != null ) {
                bones.Add(rb);
            }
        }
	}
	
	void FixedUpdate () {
        if( kickDir != 0 ) {
            KickRagdoll(kickDir);
        }
	}

    void Update() {
        if( Input.GetAxis("Vertical") > 0 ) {
            kickDir = 1;
        } else if( Input.GetAxis("Vertical") < 0 ) {
            kickDir = -1;
        } else {
            kickDir = 0;
        }
    }

    void KickRagdoll(int dir) {
        for (var i = 0; i < bones.Count; i++ ) {
            bones[i].AddForce(Vector3.forward * 50 * dir);
        }
    }

	void DisableRagdoll() {
        for (var i = 0; i < bones.Count; i++ ) {            
            bones[i].isKinematic = true;
        }
    }

    void EnableRagdoll() {
        for (var i = 0; i < bones.Count; i++) {
            bones[i].isKinematic = false;
        }
    }
}
