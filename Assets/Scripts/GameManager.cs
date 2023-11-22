using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) SwapCameras();
    }
    
    // Swap the two cameras.
    void SwapCameras() {
        if (camera1.active == false)
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
        }
        else {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }

    }
}
