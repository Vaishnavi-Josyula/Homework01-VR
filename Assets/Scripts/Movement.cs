using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 3.0f; // Movement speed
    //public CharacterController characterController; // Reference to the CharacterController component


    public Transform playerCamera; // Reference to the player's camera
    private OVRInput.Controller leftController = OVRInput.Controller.LTouch; // Left Oculus controller
    private OVRInput.Controller rightController = OVRInput.Controller.RTouch; // Right Oculus controller

    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        if (playerCamera == null)
            playerCamera = Camera.main.transform;
        
    }

    void Update()
    {
        /*
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 forward = transform.right * x + transform.forward * z;
        characterController.SimpleMove(forward * movementSpeed);
        */
        
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, rightController);

        //Debug.Log("THUMBSTICK");

        //Vector2 thumbstickInput2 = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, rightController);


        // Calculate movement direction based on the camera's forward and right vectors
        Vector3 movementDirection = playerCamera.forward * thumbstickInput.y + playerCamera.right * thumbstickInput.x;
        movementDirection.y = 0f; 

        // Move the player based on the calculated movement direction
        //characterController.Move(movementDirection * movementSpeed * Time.deltaTime);*/
    }
}
