using UnityEngine;

public class CamLook : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    [SerializeField] private Transform cam;
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.y += mouseX;
        transform.localRotation = Quaternion.AngleAxis(newRotation.y, Vector3.up);

        Vector3 newCameraRot = cam.localEulerAngles;
        newCameraRot.x -= mouseY;
        newCameraRot.x = Mathf.Clamp(newCameraRot.x, 0, 26);
        cam.localRotation = Quaternion.AngleAxis(newCameraRot.x, Vector3.right);
    }
}
