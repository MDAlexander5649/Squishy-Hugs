using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float JumpHeight = 3f;
    public float Gravity = 9.81f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    bool isGrounded;
    Vector3 velocity;


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("JUMP");
            velocity.y = 10.0f;//Mathf.Sqrt(JumpHeight * -2f * Gravity);
            controller.Move(velocity * Time.deltaTime);
        }

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 movDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(movDir.normalized * speed * Time.deltaTime);
        }
       
    }
}
