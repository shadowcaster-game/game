using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//explicação do codigo
public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform target;
    float mouseX, mouseY;
    public float dstFromTarget = 5;

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -14, 60);
    
        Vector3 targetRotation = new Vector3 (mouseY, mouseX);
        transform.eulerAngles = targetRotation;

        transform.position = target.position - transform.forward * dstFromTarget;

    }
}
