using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime;
        transform.Translate(xValue*moveSpeed, 0, zValue*moveSpeed);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the walls!!");
    }

}

