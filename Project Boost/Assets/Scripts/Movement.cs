using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // PARAMETERS
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rotationThrust = 100f;
    [SerializeField] AudioClip mainEngine;

    // CACHE
    Rigidbody rb;
    AudioSource audioSource;

    // STATE


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    {

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);

            if(!audioSource.isPlaying){
                audioSource.PlayOneShot(mainEngine);
            }
        }
        else{
            audioSource.Stop();
        }

    }

    void ProcessRotation()
    {

        if(Input.GetKey(KeyCode.A)){

            ApplyRotation(rotationThrust);

        }

        else if(Input.GetKey(KeyCode.D)){

            ApplyRotation(-rotationThrust);

        }

    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; //freezing rotation so we can manually rotate
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; //unfreezing rotation so the physics system can take over  
    }
}
