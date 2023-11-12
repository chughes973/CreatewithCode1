using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    [SerializeField] float speed = 25.0f;
    [SerializeField] float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    //Public Variables
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        //This is where we get player input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        // Rotate the vehicle instead of sliding
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        //Change Camera view by pressing F button
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;

        }
    }
}
