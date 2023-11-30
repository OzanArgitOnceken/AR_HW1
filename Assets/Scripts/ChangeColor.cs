using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject obj;

    public void ChangeToBlue()
    {
        // Check if the GameObject has a renderer component
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            // Change the material color to blue
            renderer.material.color = Color.blue;
        }
        else
        {
            Debug.LogError("The GameObject does not have a Renderer component.");
        }
    }
    public void ChangeToWhite()
    {
        // Check if the GameObject has a renderer component
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            // Change the material color to blue
            renderer.material.color = Color.white;
        }
        else
        {
            Debug.LogError("The GameObject does not have a Renderer component.");
        }
    }
    public void ChangeToRed()
    {
        // Check if the GameObject has a renderer component
        Renderer renderer = obj.GetComponent<Renderer>();

        if (renderer != null)
        {
            // Change the material color to blue
            renderer.material.color = Color.red;
        }
        else
        {
            Debug.LogError("The GameObject does not have a Renderer component.");
        }
    }
}
