using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterControl : MonoBehaviour
{
    public float Speed = 5;
    public float RunSpeed = 10;
    public Animator Anim;

    private void Start()
    {
        Anim = GetComponent<Animator>();
    }
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        bool rightInput = Input.GetKey(KeyCode.D);
        bool leftInput = Input.GetKey(KeyCode.Q);
        bool forwardInput = Input.GetKey(KeyCode.Z);
        bool backwardInput = Input.GetKey(KeyCode.S);
        bool runInput = Input.GetKey(KeyCode.LeftShift);
        

        if (runInput)
        {
            Anim.SetBool("Run", true);
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * RunSpeed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }
        else
        {
            Anim.SetBool("Run", false);
            Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
            transform.Translate(playerMovement, Space.Self);
        }

        if (rightInput && Input.GetKey(KeyCode.Z))
        {
            ResetAnim();
            Anim.SetBool("RunForwardRight", true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            ResetAnim();
            Anim.SetBool("RunBackward", true);
        }else if (Input.GetKey(KeyCode.Z))
        {
            ResetAnim();
            Anim.SetBool("Walk", true);
        }
        else ResetAnim();
        
    }
    void ResetAnim()
    {
        Anim.SetBool("Walk", false);
        Anim.SetBool("RunBackward", false);
        Anim.SetBool("RunForwardRight", false);

    }
    void PlayerMovement()
    {
        
    }
}