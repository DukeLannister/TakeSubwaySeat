using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GentlemanControl : MonoBehaviour
{
    public BlockDetect blockDetect;
    Rigidbody rigidbody3d;
    bool animatorStart;
    public float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();
        animatorStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(blockDetect.isOut)
        {
            if(animatorStart == false) 
            {
                animatorStart = true;
                rigidbody3d.constraints = RigidbodyConstraints.None;
                rigidbody3d.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX;
            }
        }
        else
        {
            animatorStart = false;
        }
    }

    void FixedUpdate()
    {
        if(animatorStart)
        {
            Debug.Log("move!");
            Vector3 position = rigidbody3d.position;
            position.z = position.z + speed * Time.deltaTime;
            rigidbody3d.MovePosition(position);
        } 
    }
}
