using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform Target; 
    public float LerpSpeed; 

    private void LateUpdate()
    {
        if (Target == null)
        {
            return;
        }
        Vector3 targetPosition = new Vector3(Target.position.x, Target.position.y, transform.position.z); 

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * LerpSpeed);
        
    }

    public void SetTarget(Transform t)
    {
        Target = t;
    }
}
