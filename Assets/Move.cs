using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    float speed = 8;
    float backward = 0.5f;
    float turnSpeed = 90;
    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    public Camera m_EnemyCam;
    void Start()
    {
        m_EnemyCam.enabled = false;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown ("space"))
        {
            m_EnemyCam.enabled = true;

        }
        if (Input.GetKeyDown("f"))
        {
            m_EnemyCam.enabled = false;

        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.back * (Time.deltaTime * backward));
        }
       // moveDir = transform.forward * Input.GetAxis("Vertical") * speed;
       // moves the character in horizontal direction
       //controller.Move(moveDir * Time.deltaTime - Vector3.up * 0.1);
    }
}