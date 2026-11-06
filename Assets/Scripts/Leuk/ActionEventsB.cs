using UnityEngine;

public class ActionEventsB : MonoBehaviour
{
    private void Start()
    {
        ActionEventsA.actionEventsA += EventThing;
    }

    void EventThing()
    {
        Debug.Log("Werkt");
    }
}
