using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 5f;

    MeshRenderer dropper_meshrenderer;
    Rigidbody dropper_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        dropper_meshrenderer = GetComponent<MeshRenderer>();
        dropper_rigidbody = GetComponent<Rigidbody>();

        dropper_meshrenderer.enabled = false;
        dropper_rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}

