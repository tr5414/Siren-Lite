using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject key;
    public Animator anim;
    private int count; 
   
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
    // Update is called once per frame
    void Update()
    {
        // if (count)
        if (key == null)
        {
            anim.Play("OpenDoor");

        }
    }
}
