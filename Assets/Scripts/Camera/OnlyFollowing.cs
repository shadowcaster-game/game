using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//explicação do codigo
public class OnlyFollowing : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform target;
    public float dstFromTarget = 5;

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {

        transform.position = target.position - transform.forward * dstFromTarget;

    }

   
}
