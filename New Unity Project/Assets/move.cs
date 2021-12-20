using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour

    // This one is a modified copy of the original movement script Jero posted on discord
{
    public bool bikeMovement; //temporary to switch between movement types from the inspector.

    [SerializeField] private float velocity = 0; // =0 for bike movement, set to >0 for wasd movement
    [SerializeField] private float acceleration;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSpeed;

    void Update()
    {
        //simple movement with wasd or arrow keys
        if (!bikeMovement)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(x, 0, z);
            transform.Translate(movement * velocity * Time.deltaTime);
        }
        //tried to simulate back and forth movement from a bike (still have to implement the oculus input)
        else
        {
            if (Input.GetKey("up") && velocity < maxSpeed) //change for oculus controller input (accelerate)
            {
                velocity += acceleration * Time.deltaTime;
            }
            if (Input.GetKey("down") && velocity > 0) //change for oculus controller input (break)
            {
                velocity -= breakForce * Time.deltaTime;
                if (velocity < 0)
                {
                    velocity = 0;
                }
            }
            transform.Translate(Vector3.forward * velocity * Time.deltaTime);
        }
    }

    // This part of the script is the bounce back mechanic ->> to copy it in the actuall script
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Obstacles")
        {
            transform.Translate(- Vector3.forward* velocity * 1f);
        }
    }
}
