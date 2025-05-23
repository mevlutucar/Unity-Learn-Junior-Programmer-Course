using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Camera hoodCamera;
    [SerializeField] Vector3 offset = new Vector3(0, 7.5f, -7.5f);

    private Camera mainCamera;
    private bool isCameraPOV = false;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
        SwitchToMainCamera();
    }

    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (isCameraPOV)
            {
                SwitchToMainCamera();
            }
            else
            {
                SwitchToHoodCamera();
            }
        }

        if (!isCameraPOV)
        {
            // Sadece ana kamera aktifken pozisyon güncelleniyor
            transform.position = player.transform.position + offset;
        }
    }

    void SwitchToHoodCamera()
    {
        mainCamera.enabled = false;
        hoodCamera.enabled = true;
        isCameraPOV = true;
    }

    void SwitchToMainCamera()
    {
        hoodCamera.enabled = false;
        mainCamera.enabled = true;
        isCameraPOV = false;
    }
}
