using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kangaroo : Animal
{
    // Start is called before the first frame update
    void Start() // can't be Awake
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        force *= 2;
        StartCoroutine(walk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // POLYMORPHISM
    protected override IEnumerator walk()
    {
        while (true)
        {
            //Debug.Log($"Kangaroo: speed={forceForward}, jumpForce={force}");

            rb.AddForce(Vector3.up * force, ForceMode.Impulse);

            // INHERITANCE
            StartCoroutine(base.walk());
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }

}
