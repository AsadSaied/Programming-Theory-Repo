using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        animal = gameObject;
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
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
            //Debug.Log($"Cat: forwardForce={forceForward}, force={force}");

            // INHERITANCE
            StartCoroutine(base.walk());
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }
}
