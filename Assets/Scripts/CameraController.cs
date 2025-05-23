using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 7.5f, -7.5f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }


}
