using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    bool keycheck = false;
    public GameObject key;
    // Start is called before the first frame update
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
            {
          //  Debug.Log("Text: butts");

            //  if (keycheck = true)
            if (keycheck == true)
            {
            Debug.Log("Text: poooppp");

            Destroy(key);
            }
        }
    }
    

    //Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Key")
        {
           keycheck = true;
            Debug.Log("Text: buttttsss");
        }
        //count++;
        //   Destroy(key);
        //Instantiate(effect, transform.position, transform.rotation);
    }
    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Key")
        {
            keycheck = false;
            Debug.Log("Text: booty");
        }
        //count++;
        //   Destroy(key);
        //Instantiate(effect, transform.position, transform.rotation);
    }
}
        
    

