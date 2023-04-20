using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextSceneCapture : MonoBehaviour
{
    public float detectionRange = 5f;


    private bool canCapture = false;

    private void Update()
    {
        if (canCapture && Input.GetKeyDown(KeyCode.E))
        {
            CaptureObject();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canCapture = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canCapture = false;
        }
    }

    private void CaptureObject()
    {
        // Get the index of the current scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}

