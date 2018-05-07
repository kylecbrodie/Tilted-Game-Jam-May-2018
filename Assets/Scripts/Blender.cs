using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blender : MonoBehaviour
{
    private Rigidbody rb;


    public int direction_of_vacumm;
    //1 or -1

 

    private float vacuum_effect = 300f;

    // Use this for initialization
    void Start ()
    {
      rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerStay(Collider other)
    {
        vacuum_effect = 300f * direction_of_vacumm;

        print("On Trigger working");
        other.attachedRigidbody.AddForce(Vector3.back * vacuum_effect * Time.deltaTime);

        //other.attachedRigidbody.AddForceAtPosition( Vector3.back * vacuum_effect * Time.deltaTime, Vector3(0,0,transform.position.z) , ForceMode.Force);
    }
}
