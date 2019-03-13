using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Flashlight : MonoBehaviour
{
    public bool on = false;
    public bool HasLight = false;
    public Light light;
    void Start()
    {
        light = GetComponent<Light>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Flashlight")
        {
            //other.gameObject.SetActive(false);
            //count = count + 1;
            HasLight = true;

            // countText.text = "Count: " + count.ToString();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)&& HasLight == true)
            on = !on;
        if (on)
            light.enabled = true;
        else if (!on)
            light.enabled = false;
    }
}