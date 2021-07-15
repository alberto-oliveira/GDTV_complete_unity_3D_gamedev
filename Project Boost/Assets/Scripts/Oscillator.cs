using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // PARAMETERS
    [SerializeField] Vector3 movementVector;
    [SerializeField] [Range(-1, 1)] float movementFactor;

    // CACHE

    // STATE
    Vector3 startingPos;

\
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
