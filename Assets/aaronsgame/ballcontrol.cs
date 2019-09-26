using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontrol : MonoBehaviour {

    public float speed;
    public Rigidbody2D weast;

    // Start is called before the first frame update
    void Start()
    {
    speed = 10f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            weast.MovePosition(transform.position + new Vector3(-1, 0) * Time.fixedDeltaTime * speed);// += Vector3.left * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            weast.MovePosition(transform.position + new Vector3(1, 0) * Time.fixedDeltaTime * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            weast.MovePosition(transform.position + new Vector3(0, 1) * Time.fixedDeltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            weast.MovePosition(transform.position + new Vector3(0, 1) * Time.fixedDeltaTime * speed);
        }



    }
}
