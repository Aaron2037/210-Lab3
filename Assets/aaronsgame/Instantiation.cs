using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    //public Rigidbody ballybigboiPrefab;
    public GameObject InstantiatedBall;
    public Camera Cam;
    public camerafollow CamFollow;
    public GameObject ballPrefab;




    private void Update()
    {
        Vector3 position = Cam.ScreenToWorldPoint(Input.mousePosition);
        position.z = 0f;

        if (Input.GetMouseButtonDown(0))
        {
            InstantiatedBall = Instantiate(ballPrefab, position, Quaternion.identity);
            CamFollow.SetTarget(InstantiatedBall.transform);
        }
    }
   
}

