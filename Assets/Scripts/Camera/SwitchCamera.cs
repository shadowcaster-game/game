using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//jeito melhor de implementar alternando entre "q" e "e"
public class SwitchCamera : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;

    Vector3 displacement;

    void Update()
    {
        if (Input.GetButtonDown("Cam1"))
        {
            
            mainCamera.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
                
        }

       if (Input.GetButtonDown("Cam2"))
        {

            mainCamera.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
            camera4.SetActive(false);
                
        }
        
        if (Input.GetButtonDown("Cam3"))
        {
            
            mainCamera.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
            camera4.SetActive(false);
                
        }

        if (Input.GetButtonDown("Cam4"))
        {
            
            mainCamera.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(true);
                
        }

        else if (Input.GetButtonDown("Walk"))
        {
            mainCamera.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
            camera4.SetActive(false);
        }
    }
}
