using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// The Script should not be attached to a game object.
// For some reason it causes an error "NullReferenceException"
public class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected Rigidbody rb;
    protected GameObject animal;
    protected float speed;
    protected float force;
    protected float repeatInSeconds;
    protected Vector3 originalPosition;

    private void Awake()
    {
        repeatInSeconds = 1;
        speed = 3;
        force = 100;
    }

    protected virtual void FixedUpdate()
    {
        Debug.Log("Speed= " + speed);
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
    }

    // ABSTRACTION
    protected virtual IEnumerator Jump(bool isForever)
    {
        while (isForever)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }

    // ABSTRACTION
    // POLYMORPHISM
    protected virtual IEnumerator Jump()
    {

        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        yield return new WaitForSeconds(repeatInSeconds);

    }

    // ABSTRACTION
    protected virtual IEnumerator Sidewinding(short direction)
    {
        while (true)
        {
            rb.AddForce(Vector3.right * force * direction, ForceMode.Impulse);
            direction *= -1;
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }

    // When we touched the sensor, we will reset the animal position
    protected void OnTriggerEnter(Collider other)
    {
        //animal.transform.position = originalPosition; // works
        transform.position = originalPosition;          // works
    }
}

