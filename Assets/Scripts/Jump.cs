using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [Space]

    [SerializeField] private InputActionReference jumpKey;
    [SerializeField] private InputActionReference resetKey;

    private Vector3 randomTorqueVector;

    private void Update()
    {
        //Debug.Log("Hallo! ik ben update!");
        if (jumpKey.action.WasPressedThisFrame()) ObjectJump();
        if (resetKey.action.WasPressedThisFrame()) ResetObj();
    }

    private void ObjectJump()
    {
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            float randomTorque = Random.Range(-jumpForce, jumpForce);

            randomTorqueVector = new Vector3(randomTorqueVector.x, randomTorqueVector.y, randomTorqueVector.z);
            rb.AddTorque(randomTorqueVector);
        }
    }

    private void ResetObj()
    {
        transform.position = Vector3.zero;
        transform.rotation = Quaternion.identity;
        rb.linearVelocity = Vector3.zero;
    }
}
