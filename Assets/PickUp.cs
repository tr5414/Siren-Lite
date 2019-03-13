using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{
    public GameObject effect;
    public int count = 0;
    void Update()
    {
     //   transform.Rotate(new Vector3(15, 15, 0) * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //other.gameObject.SetActive(false);
            //count = count + 1;
            Destroy(gameObject);

            Instantiate(effect, transform.position, transform.rotation);
            // countText.text = "Count: " + count.ToString();
        }
    }
}