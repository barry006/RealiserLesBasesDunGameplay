using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    DestroyOutOfBounds dob;

    private void Awake()
    {     
        dob = gameObject.GetComponent<DestroyOutOfBounds>();
    }
    void OnTriggerEnter(Collider other) 
    {


        if (other.tag == "Player")
        {
            dob.gover();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }


    }
}
