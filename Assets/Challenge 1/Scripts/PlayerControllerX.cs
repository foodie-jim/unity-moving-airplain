using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        Vector3 moveDirection = new Vector3(v, h, 0);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(moveDirection * rotationSpeed * Time.deltaTime);
    }
}
