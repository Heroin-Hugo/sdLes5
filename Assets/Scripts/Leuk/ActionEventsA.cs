using UnityEngine;
using System;

public class ActionEventsA : MonoBehaviour
{
    public static event Action actionEventsA;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SendEvent();
    }

    private void SendEvent() => actionEventsA?.Invoke();
}
