using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor_Belt : MonoBehaviour
{

    // Use this for initialization

    private float speed_of_conveyor = 55f;


    //Collision Collision_of_conveyor;

    void Start()
    {
        //Collision_of_conveyor = GetComponent<Collision>();

    }

    void ForceUpdate()
    {
        /// OnCollisionStay(Collision_of_conveyor);
        

    }

    private void OnCollisionStay(Collision collision)
    {
        float coveyorVelocity = speed_of_conveyor * Time.deltaTime;

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();


        //if we want to add force
        rb.AddForce(Vector3.forward *  coveyorVelocity);


        //Just moving it with MovePosition
       // transform.Translate(Vector3.forward * coveyorVelocity);
        //rb.MovePosition(coveyorVelocity);
    }
}


