using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected GameObject animal;
    protected Rigidbody rb;
    protected float forceForward;
    protected float force;
    protected float repeatInSeconds;
    protected Vector3 originalPosition;

    private void Awake() // make sure that these values are set before we start the game
    {
        repeatInSeconds = 3;
        forceForward = 50;
        force = 100;
    }

    private void Update()
    {
        
    }

    protected virtual IEnumerator walk()
    {
        //Debug.Log("Passed");
        
        rb.AddForce(Vector3.forward * forceForward, ForceMode.Impulse);
        yield return new WaitForSeconds(repeatInSeconds);
    }

    protected void OnTriggerEnter(Collider other)
    {
        //animal.transform.position = originalPosition; // works
        transform.position = originalPosition;          // works
    }
}

