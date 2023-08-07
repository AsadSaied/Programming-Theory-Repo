using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal   // INHERITANCE
{
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();

        // movement speed
        speed *= 1.5f;
        
        //animal = gameObject;
    }

    // INHERITANCE
    // No Override, therefore, it is commented
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }
}
