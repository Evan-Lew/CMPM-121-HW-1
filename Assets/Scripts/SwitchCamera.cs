using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SwitchCamera : MonoBehaviour
{
    public List<Camera> Cameras;
    private void Start()
    {
        EnableCamera(0);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableCamera(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EnableCamera(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            EnableCamera(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GameObject.Find("Master Timeline").GetComponent<PlayableDirector>().enabled = true;
            EnableCamera(5);
        }
    }

    private void EnableCamera(int n)
    {
        Cameras.ForEach(cam =>cam.enabled = false);
        Cameras[n].enabled = true;
    }
}
