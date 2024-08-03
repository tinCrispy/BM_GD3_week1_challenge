using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorMill : MonoBehaviour
{
    

    float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (rotationSpeed < -1 && rotationSpeed > 1)
        {
            rotationSpeed = Random.Range(-5, 5);
        }

        transform.Rotate(0, 0, rotationSpeed);
    }

}
