using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // GetAxis Method
    // Time.deltaTime is a timeframe in seconds
    public float speed;
    private string tag_wall = "Wall";
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // Debug.Log("Horizontal: " + horizontalInput + " Vertical: " + verticalInput);
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag== tag_wall){
            Debug.Log("Collided with wall");
            ScoreManager.instance.AddScore(-1);

        }
    }
}
