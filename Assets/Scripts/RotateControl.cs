using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateControl : MonoBehaviour
{
    float rotationSpeed = 950;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.MoveRotation(GetComponent<Rigidbody2D>().rotation + (rotationSpeed*Time.deltaTime));
            //transform.Rotate(0, 0, rotationSpeed);
        }
        else if(Input.GetKey(KeyCode.RightArrow)) {
            rb.MoveRotation(GetComponent<Rigidbody2D>().rotation - (rotationSpeed * Time.deltaTime));
            //transform.Rotate(0, 0, -rotationSpeed);
        }
    }


}
