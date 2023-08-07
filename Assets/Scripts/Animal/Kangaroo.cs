using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kangaroo : Animal  // INHERITANCE
{
    // Start is called before the first frame update
    void Start() // can't be Awake
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();

        // jump force and start the coroutine
        force *= 2;
        StartCoroutine(Jump(true));

        //animal = gameObject;
    }

    // INHERITANCE
    // No Override, therefore, it is commented
    /*protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }*/
}
