using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal // INHERITANCE
{
    // ENCAPSULATION
    private short direction = 1;


    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        repeatInSeconds /= 2;

        // movement speed
        speed /= 2;

        // Sidewinding force and start the couroutine
        force /= 4;
        StartCoroutine(Sidewinding(direction));

        //animal = gameObject;
    }

    // INHERITANCE
    // No Override, therefore, it is commented
    /*protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }*/
}
