using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : Animal
{
    private short direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        forceForward /= 2;
        force /= 4;
        repeatInSeconds = 1;
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
            //Debug.Log($"Snake: forwardForce={forceForward}, force={force}");

            rb.AddForce(Vector3.right * force * direction, ForceMode.Impulse);
            direction *= -1;
            StartCoroutine(base.walk());
            yield return new WaitForSeconds(repeatInSeconds);
        }
    }
}
