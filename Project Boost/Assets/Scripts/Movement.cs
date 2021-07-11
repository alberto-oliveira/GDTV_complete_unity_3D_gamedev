using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;

    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotationThrust = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {

        if(Input.GetKey(KeyCode.Space)){

            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);

        }

    }

    void ProcessRotation()
    {

        if(Input.GetKey(KeyCode.A)){

            transform.Rotate(Vector3.forward * rotationThrust * Time.deltaTime);

        }

        else if(Input.GetKey(KeyCode.D)){

            transform.Rotate(-Vector3.forward * rotationThrust * Time.deltaTime);

        }

    }
}
