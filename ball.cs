using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float ballSpeed = 1000f;
    public float moveSpeed = 5f;
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(ballSpeed * transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        move.x = Input.GetAxis("Horizontal");
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}
