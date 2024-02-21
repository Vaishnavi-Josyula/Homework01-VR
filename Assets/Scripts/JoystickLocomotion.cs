using UnityEngine;
public class JoystickLocomotion : MonoBehaviour
{
    public Transform cameraRigTransform; 
    public float speed;
    void Update()
    {
        var joystickAxis = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick, OVRInput.Controller.LTouch);
        Vector3 movementDirection = cameraRigTransform.right * joystickAxis.x +
                                    cameraRigTransform.forward * joystickAxis.y;
        Vector3 movement = movementDirection * Time.deltaTime * speed;
        cameraRigTransform.position += new Vector3(movement.x, 0f, movement.z);
    }
}