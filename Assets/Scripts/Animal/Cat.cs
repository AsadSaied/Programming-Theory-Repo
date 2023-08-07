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
        forceForward /= 3;
        rb = GetComponent<Rigidbody>();
        StartCoroutine(walk());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override IEnumerator walk()
    {
        while (true)
        {
            //Debug.Log($"Cat: forwardForce={forceForward}, force={force}");

            StartCoroutine(base.walk());
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }
}
