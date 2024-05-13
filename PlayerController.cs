using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public CharacterController controller;
    public float speed = 12f;
    public float turnSmoothTime = 0.05f;
    [SerializeField] private float gravityMuliplyer = 3f;
    public GameObject camera;

    private Animator animator;

    float turnSpeed;
    private float gravity = -9.81f;
    private Vector3 velocity;


    // Links components to script
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }


    // Main movement loop
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 tempDirection = direction;

        // If the scene has movement linked to a camera it transforms the direction of movement according to the camera
        if (camera != null)
        {
            direction = camera.transform.TransformDirection(direction);
        }


        // Vertical movement
        if (controller.isGrounded && velocity.y<0.0f)
        {
            velocity.y = 0.0f;
            animator.SetFloat("Speed", direction.magnitude);
            }
        else{
            velocity.y = gravity * gravityMuliplyer * Time.deltaTime; 
            controller.Move(velocity);
        }
            

        //Horizontal movement
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.z, -direction.x)*Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle, ref turnSpeed, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            controller.Move(direction * speed * Time.deltaTime);
        }
        animator.SetFloat("Speed", direction.magnitude);
    }

}
