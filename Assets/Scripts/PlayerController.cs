using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float vehicleSpeed;
    [SerializeField] float turnSpeed;

    [SerializeField] float horizontalInput, forwardInput;
    void Start()
    {
        
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
