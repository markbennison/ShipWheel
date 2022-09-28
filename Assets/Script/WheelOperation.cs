using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelOperation : MonoBehaviour
{
    Rigidbody wheelRB;

    void Start()
    {
        if (GameObject.Find("Wheel").GetComponent<Rigidbody>() == null)
        {
            GameObject.Find("Wheel").AddComponent<Rigidbody>();
        }
        wheelRB = GameObject.Find("Wheel").GetComponent<Rigidbody>();
        wheelRB.useGravity = false;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            wheelRB.MoveRotation(wheelRB.rotation * Quaternion.Euler(0, 0, -1));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            wheelRB.rotation = Quaternion.identity;
        }
    }
}
