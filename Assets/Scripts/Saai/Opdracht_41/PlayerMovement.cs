using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody rb;
    private Vector3 moveVector;

    private void Update()
    {
        CheckPlayerMovement();
    }

    private void CheckPlayerMovement()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");

        rb.linearVelocity = moveVector * moveSpeed;
    }
}
