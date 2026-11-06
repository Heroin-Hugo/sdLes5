using UnityEngine;
using System;
public class CoinPickup : MonoBehaviour
{
    public static event Action onCoinPickup;
    [SerializeField] private ParticleSystem pickupPart;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupPart, transform.position, Quaternion.identity);
            onCoinPickup?.Invoke();
            Destroy(gameObject);
        }
    }
}
