using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotSpeed;
    public float gravity;
    public float rot;

    public Vector3 moveDir = Vector3.zero;
    public CharacterController controller;
    public Animator animator;

    private float ScreenWidth;
    public GameObject character;
    private Rigidbody characterBody;


    public float hinput = Input.GetAxis("Horizontal");

    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (controller.isGrounded)
        {
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;

        }
        int i = 0;
        //loop over every touch found
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                //move right
                rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
                transform.localEulerAngles = new Vector3(0, rot, 0);
                moveDir.y -= gravity * Time.deltaTime;
                controller.Move(moveDir * Time.deltaTime);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                rot += -Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
                transform.localEulerAngles = new Vector3(0, -rot, 0);
                moveDir.y -= gravity * Time.deltaTime;
                controller.Move(-moveDir * Time.deltaTime);
            }
            ++i;
        }
        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.localEulerAngles = new Vector3(0, rot, 0);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        rot = 0;
    }
}