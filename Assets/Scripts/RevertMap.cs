using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertMap : MonoBehaviour
{
    public bool directionChanged{get; private set;}

    void Start()
    {
        directionChanged = false;
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            transform.up = new Vector3(0, 0, 0);
            directionChanged = true;
        }
    }
}
