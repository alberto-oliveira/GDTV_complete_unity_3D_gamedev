using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 10f;
    [SerializeField] float zAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);
    }
}
