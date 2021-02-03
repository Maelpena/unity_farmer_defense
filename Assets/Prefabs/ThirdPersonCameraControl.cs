using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraControl : MonoBehaviour
{
    float rotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    public Camera camera;
    private bool aiming = false;
    public Transform Obstruction;
    float zoomSpeed = 2f;
    
    void Start()
    {
        Obstruction = Target;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        CamControl();
        if (Input.GetMouseButton(1))
        {
            aiming = true;
        }
        else
        {
            aiming = false;
        }
        Scope();
    }

    void Scope()
    {
        //cameraComponent.fieldOfView = 10;
        if (aiming == true && camera.fieldOfView > 27)
        {
            Debug.Log("je vise");
            camera.fieldOfView -= 100f * Time.deltaTime;
        }
        if (aiming == false && camera.fieldOfView < 40)
        {
            camera.fieldOfView += 100f * Time.deltaTime;
            Debug.Log("je vise plus");

        }
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -50, 50);

        transform.LookAt(Target);

        if (Input.GetKey(KeyCode.T))
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else
        {
            Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            
            Player.rotation = Quaternion.Euler(0, mouseX, 0);
        }
    }
    

   /* void ViewObstructed()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Target.position - transform.position, out hit, 4.5f))
        {
            if (hit.collider.gameObject.tag != "Player")
            {
                Obstruction = hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
                
                if(Vector3.Distance(Obstruction.position, transform.position) >= 3f && Vector3.Distance(transform.position, Target.position) >= 1.5f)
                    transform.Translate(Vector3.forward * zoomSpeed * Time.deltaTime);
            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
                if (Vector3.Distance(transform.position, Target.position) < 4.5f)
                    transform.Translate(Vector3.back * zoomSpeed * Time.deltaTime);
            }
        }
    }*/
}