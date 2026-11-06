using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    private void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(0, 0, Time.deltaTime);

        // Move the object upward in world space 1 unit/second.
        transform.Translate(0, Time.deltaTime, 0, Space.World);
    }
}
