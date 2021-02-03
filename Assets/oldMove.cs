using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldMove : MonoBehaviour
{
    public float speed;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("z"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed * 2.5f;
        }
        else if (Input.GetKey("z"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        }

        if (Input.GetKey("q"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }
        else if (Input.GetKey("d"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * speed;
        }

    }
}
