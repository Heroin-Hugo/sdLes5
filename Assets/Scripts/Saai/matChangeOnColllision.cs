using UnityEngine;

public class matChangeOnColllision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) => other.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
}
