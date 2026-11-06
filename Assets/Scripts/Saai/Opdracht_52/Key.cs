using UnityEngine;
using System;
public class Key : MonoBehaviour
{   
    public static event Action onKeyPickup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindAnyObjectByType<Door>().UnlockDoor();
            Destroy(gameObject);
        }
    }
}
