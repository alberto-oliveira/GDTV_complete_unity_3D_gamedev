using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    void OnCollisionEnter(Collision other) {

        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("Bumped in friendly object");
                break;
            case "Finish":
                Debug.Log("Reached the finish!");
                break;
            case "Fuel":
                Debug.Log("Collected Fuel!");
                break;
            default:
                Debug.Log("Bumped in Obstacle! DED!");
                ReloadLevel();
                break;

        }
        
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
