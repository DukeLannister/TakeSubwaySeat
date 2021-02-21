using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDetect : MonoBehaviour
{
    public bool isOut{get; private set;}

    void Start()
    {
        isOut = false;
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag == "BlockObject")
        {
            isOut = true;
            Debug.Log("Block Out!");
        }
        if(other.tag == "Human")
        {
            isOut = false;
        }
    }
}
