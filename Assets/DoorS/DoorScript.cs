using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject key;
    public Animator anim;
    private int count;
    bool doorcheck = false;


    // private int count;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void counter()
    {
        count++;
       
    }
    void Update()
    {
        if (Input.GetKey("e"))        {
            //  Debug.Log("Text: butts");

            //  if (keycheck = true)
            if (doorcheck == true)
            {
                Debug.Log("Text: open");

                anim.Play("Door_open");
            }
        }

    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        // if (count)
        if (key == null)
        {
            doorcheck = true;
        }
    }
}
