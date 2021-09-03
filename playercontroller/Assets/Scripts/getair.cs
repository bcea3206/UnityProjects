using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getair : MonoBehaviour
{
    public float jumpforce;
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Rigidbody playerRb = other.GetComponent<Rigidbody>();

            playerRb.AddForce(other.transform.up * jumpforce, ForceMode.Impulse);
        }
    }

}
