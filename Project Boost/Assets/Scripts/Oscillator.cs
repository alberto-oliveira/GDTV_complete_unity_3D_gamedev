using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // PARAMETERS
    [SerializeField] Vector3 movementVector;

    [SerializeField] float period = 2f;

    // CACHE

    // STATE
    float movementFactor;
    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float cycles = Time.time / period; // Continually Growing over time
        const float tau = 2 * Mathf.PI; // Constant value of 6.283
        float rawSineWave = Mathf.Sin(cycles * tau); // Going from -1 to 1

        movementFactor = (rawSineWave + 1f)/2; // Recalculated to go grom 0 to 1

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
    }
}
