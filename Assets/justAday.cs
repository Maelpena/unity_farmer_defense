using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justAday : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public int time;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, new Vector3(0, 0, 1), time * Time.deltaTime);
        
        if (this.transform.position.y < -20)
        {
            this.GetComponentInChildren<Light>().intensity=0;
        }

        else
        {
            this.GetComponentInChildren<Light>().intensity = 2;
        }

    }
}
