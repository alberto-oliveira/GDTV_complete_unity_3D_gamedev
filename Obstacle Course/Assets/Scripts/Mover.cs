using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float yValue = 0.0f;

    [SerializeField] float moveSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(xValue*moveSpeed, yValue, zValue*moveSpeed);
    }
}
