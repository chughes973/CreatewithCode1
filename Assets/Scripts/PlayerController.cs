using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    //[SerializeField] float speed = 25.0f;
    [SerializeField] private float horsePower = 0;
    [SerializeField] float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    //Public Variables
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;

    // Start is called before the first frame update
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //This is where we get player input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
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
