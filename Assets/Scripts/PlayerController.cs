using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float vehicleSpeed;
    void Start()
    {
        
    }


    void Update()
    {
        //Move forward the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
