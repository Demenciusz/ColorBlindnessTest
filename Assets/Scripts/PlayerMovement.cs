using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float gravity = 10000f;
    public float speed = 3f;
    private CharacterController playerController;

    private void Start()
    {
        playerController = GetComponent<CharacterController>();
    }


    void Update()
    {
        Movment();
    }

    void Movment()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 velocity = direction * speed;
        velocity = Camera.main.transform.TransformDirection(velocity);
        velocity.y -= gravity;
        playerController.Move(velocity * Time.deltaTime);
    }
}
