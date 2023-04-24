using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.tag = "Entered";
        other.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.name = "Empty";
        collision.transform.parent = transform;
    }
}
