using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TravellerGo : MonoBehaviour
{
    public GameObject map;
    RevertMap revertMap;
    TMP_Text text;
    Rigidbody rigidbody3d;
    public Transform[] roadPoints;
    int length;
    int index;
    
    // Start is called before the first frame update
    void Start()
    {
        revertMap = map.GetComponent<RevertMap>();
        text = GetComponentInChildren<TMP_Text>();
        rigidbody3d = GetComponent<Rigidbody>();
        index = 0;
        length = roadPoints.Length;
    }

    void Update()
    {
        if(index > 0 && index < length)
        {
            if(transform.position == roadPoints[index - 1].position)
            {
                rigidbody3d.MovePosition(roadPoints[index].position);
                index += 1;
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other) {
        if(revertMap.directionChanged && other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            text.text = "Enlightened Traveller";
            rigidbody3d.constraints = RigidbodyConstraints.None;
            rigidbody3d.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
            rigidbody3d.MovePosition(roadPoints[index].position);
            index += 1;
        }
    }
}
