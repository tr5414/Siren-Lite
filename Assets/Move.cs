using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    public Camera EnemyCam;
    public Camera StartCam;
    public Camera UHallCamera;
    public Camera LHallCamera;
    public Camera LLCamera;
    public Camera MRCamera;
    public Camera MLCamera;
    public Camera ULCamera;
    public Camera URCamera;
    public bool Horizontal = false;
    float speed = 8;
    public float backward = 0.5f;
  public float turnSpeed = 90;
    CharacterController controller;
   // Vector3 moveDir = Vector3.zero;
    public Camera m_EnemyCam;
    void Start()
    {
        m_EnemyCam.enabled = false;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetButton ("Fire2"))
        {
            m_EnemyCam.enabled = true;
            ChangeSplitScreen();

        }
else       
 {
           m_EnemyCam.enabled = false;
            StartCam.rect = new Rect(0, 0, 1, 1);
            UHallCamera.rect = new Rect(0, 0, 1, 1);
            LHallCamera.rect = new Rect(0, 0, 1, 1);
            LLCamera.rect = new Rect(0, 0, 1, 1);
            MRCamera.rect = new Rect(0, 0, 1, 1);
            MLCamera.rect = new Rect(0, 0, 1, 1);
            ULCamera.rect = new Rect(0, 0, 1, 1);
            URCamera.rect = new Rect(0, 0, 1, 1);

        }
        // else 
        //   {
        //        m_EnemyCam.enabled = false;

        //   }
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
    public void ChangeSplitScreen()
    {
        Horizontal = !Horizontal;

        if (Horizontal)
        {
            EnemyCam.rect = new Rect(0, 0, 0.5f, 1);
            StartCam.rect = new Rect(0.5f, 0, 0.5f, 1);
              UHallCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             LHallCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             LLCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             MRCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             MLCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             ULCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             URCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
            //Update();
        }
        else
        {
            EnemyCam.rect = new Rect(0, 0, 0.5f, 1);
            StartCam.rect = new Rect(0.5f, 0, 0.5f, 1);
             UHallCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             LHallCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             LLCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             MRCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             MLCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             ULCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
             URCamera.rect = new Rect(0.5f, 0, 0.5f, 1);
            //Update();
        }
    }
}