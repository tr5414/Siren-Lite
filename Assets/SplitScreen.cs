using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    public Camera EnemyCam;
    public Camera PlayerCam;
    public bool Horizontal = false;   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
            ChangeSplitScreen();
    }
    public void ChangeSplitScreen()
    {
        Horizontal = !Horizontal;

        if (Horizontal)
        {
            EnemyCam.rect = new Rect(0, 0, 0.5f, 1);
            PlayerCam.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
        else
        {
            EnemyCam.rect = new Rect(0, 0, 0.5f, 1);
            PlayerCam.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
    }
}
