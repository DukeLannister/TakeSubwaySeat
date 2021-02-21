using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontal;
    float vertical;
    public float speed;
    Rigidbody rigidbody3d;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody3d = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0, vertical);
    }

    void FixedUpdate()
    {
        Vector3 position = rigidbody3d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.z = position.z + speed * vertical * Time.deltaTime;

        rigidbody3d.MovePosition(position);
    }
}
