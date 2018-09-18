using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    //private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float moveHoizental = Input.GetAxis("Horizontal");
        float moveVerticle = Input.GetAxis("Vertical");
        Vector3 movment = new Vector3(moveHoizental, 0.0f, moveVerticle);
        rb.AddForce(movment * 10);
    }
}
