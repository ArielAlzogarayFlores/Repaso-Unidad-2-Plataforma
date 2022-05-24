using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    public float zSpeed;
    public float RotationSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < 4.5f)
        {
            //transform.position += new Vector3(0, 0, zSpeed);
            //transform.Translate(0, 0, zSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, zSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -zSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotationSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotationSpeed, 0);
        }
        


    }
}
