using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(0, 0, Time.deltaTime);

        transform.Translate(0, Time.deltaTime, 0, Space.World);
    }
}
