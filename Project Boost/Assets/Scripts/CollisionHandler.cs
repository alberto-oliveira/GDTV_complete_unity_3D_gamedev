using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{

    // PARAMETERS
    [SerializeField] float sceneLoadDelay = 2f;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip success;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] ParticleSystem successParticles;

    // CACHE

    AudioSource audioSource;

    // STATE
    bool isTransitioning = false;
    

    // DEBUG
    bool debugCollisionDisabled = false;


    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update() {
        DebugKeys();
    }


    void OnCollisionEnter(Collision other) {

        if(isTransitioning || debugCollisionDisabled){ return; }

        switch(other.gameObject.tag)
        {
            case "Friendly":
                break;
            case "Finish":
                StartLoadSequence();
                break;
            default:
                StartCrashSequence();
                break;

        }

    }

    void StartCrashSequence()
    {
        isTransitioning = true;
        GetComponent<Movement>().enabled = false;
        audioSource.Stop();
        audioSource.PlayOneShot(crash, 0.3f);
        crashParticles.Play();
        Invoke("ReloadLevel", sceneLoadDelay);
    }

    void StartLoadSequence()
    {
        isTransitioning = true;
        GetComponent<Movement>().enabled = false;
        audioSource.Stop();
        audioSource.PlayOneShot(success, 0.3f);
        successParticles.Play();
        Invoke("LoadNextLevel", sceneLoadDelay);
    }

    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel()
    {
        int numScenes = SceneManager.sceneCountInBuildSettings;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene((currentSceneIndex + 1) % numScenes);
    }

    void DebugKeys()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            Debug.Log("Debug Key L: Loading next level");
            LoadNextLevel();
        }
        else if(Input.GetKeyDown(KeyCode.C)){
            Debug.Log("Debug Key C: Disabling collisions. Press Again to enable");
            debugCollisionDisabled = !debugCollisionDisabled;
        }
    }

}
