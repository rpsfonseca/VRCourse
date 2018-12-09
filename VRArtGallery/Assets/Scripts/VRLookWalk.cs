using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;

    public GameObject canvas;

    public float toggleAngle = 30.0f;

    public float speed = 3.0f;

    public bool moveforward;
    public bool movebackward;
    public bool moveleft;
    public bool moveright;

    private CharacterController cc;
    private bool connected = false;


    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        StartCoroutine(CheckForControllers());
    }

    IEnumerator CheckForControllers() {
    while (true) {
        var controllers = Input.GetJoystickNames();
        // Debug.Log(controllers.Length);
        if (!connected && controllers.Length > 0) {
            connected = true;
            // Debug.Log("Connected");
        } else if (connected && controllers.Length == 0) {
            connected = false;
            // Debug.Log("Disconnected");
        }
        yield return new WaitForSeconds(1f);
    }
}

    // Update is called once per frame
    void Update()
    {
        // right
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
            Debug.Log("JoystickButton0");
        
        // right release
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
            Debug.Log("JoystickButton1");
        
        // top
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
            Debug.Log("JoystickButton2");

        // top release
        if (Input.GetKeyDown(KeyCode.JoystickButton3))
            Debug.Log("JoystickButton3");
        
        // bottom
        if (Input.GetKeyDown(KeyCode.JoystickButton4))
            Debug.Log("JoystickButton4");
        
        // bottom release
        if (Input.GetKeyDown(KeyCode.JoystickButton5))
            Debug.Log("JoystickButton5");
        
        // left 
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
            Debug.Log("JoystickButton6");
        
        // C
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
            Debug.Log("JoystickButton7");
        
        // A
        if (Input.GetKeyDown(KeyCode.JoystickButton8) || Input.GetKey(KeyCode.A))
            Debug.Log("JoystickButton8");

        // A release 
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
            Debug.Log("JoystickButton9");
        
        // B
        if (Input.GetKeyDown(KeyCode.JoystickButton10) || Input.GetKey(KeyCode.B))
            Debug.Log("JoystickButton10");
        
        // B release
        if (Input.GetKeyDown(KeyCode.JoystickButton11))
            Debug.Log("JoystickButton11");
        
        // left release
        if (Input.GetKeyDown(KeyCode.JoystickButton12))
            Debug.Log("JoystickButton12");
        
        // C release
        if (Input.GetKeyDown(KeyCode.JoystickButton13))
            Debug.Log("JoystickButton13");
        
        // D
        if (Input.GetKeyDown(KeyCode.JoystickButton14))
            Debug.Log("JoystickButton14");
        
        // D release
        if (Input.GetKeyDown(KeyCode.JoystickButton15))
            Debug.Log("JoystickButton15");

        // vrCamera.eulerAngles.x >= 180 && vrCamera.eulerAngles.x <= (360 - toggleAngle) ||
        // vrCamera.eulerAngles.x <=180 && vrCamera.eulerAngles.x >= toggleAngle ||

// ---------------------------------------------------------------

        if ( Input.GetKeyDown(KeyCode.JoystickButton2) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveforward = true;
            movebackward = false;

        } 
        else if ( Input.GetKeyDown(KeyCode.JoystickButton4)|| Input.GetKeyDown(KeyCode.DownArrow) )
        {
            moveforward = false;
            movebackward = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton3) || Input.GetKeyDown(KeyCode.JoystickButton5)) {
                moveforward = false;
                movebackward = false;
            }
        }

// ---------------------------------------------------------------

        if ( Input.GetKeyDown(KeyCode.JoystickButton6)|| Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveleft = true;
            moveright = false;

        } 
        else if ( Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.RightArrow) )
        {
            moveleft = false;
            moveright = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.JoystickButton12)) {
                moveleft = false;
                moveright = false;
            }
        }

// ---------------------------------------------------------------

        if (moveforward == true)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
        
        if (movebackward == true)
        {
            Vector3 backward = vrCamera.TransformDirection(-Vector3.forward);

            cc.SimpleMove(backward * speed);
        }

        if (moveleft == true)
        {
            Vector3 left = vrCamera.TransformDirection(-Vector3.right);
            cc.SimpleMove(left * speed);
        }

        if (moveright == true)
        {
            Vector3 right = vrCamera.TransformDirection(Vector3.right);
            cc.SimpleMove(right * speed);
        }

// ---------------------------------------------------------------

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            moveleft = false;
        }
        
        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            moveright = false;
        }
        
        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            moveforward = false;
        }
        
        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            movebackward = false;
        }

// ---------------------------------------------------------------

        if (InteractionManager.currentInteractable != null && (Input.GetKeyDown(KeyCode.JoystickButton7) || Input.GetKeyDown(KeyCode.C)))
        {
            Debug.Log("Interaction with sculpture");
            InteractionManager.Engage();
            if (canvas && canvas.activeInHierarchy)
            {
                canvas.SetActive(false);
            }
        }
    }
}
