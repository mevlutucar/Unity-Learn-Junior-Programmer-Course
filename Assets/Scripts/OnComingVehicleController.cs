using UnityEngine;

public class OnComingVehicleController : MonoBehaviour
{

    [SerializeField] float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,1 * speed * Time.deltaTime);
    }
}
