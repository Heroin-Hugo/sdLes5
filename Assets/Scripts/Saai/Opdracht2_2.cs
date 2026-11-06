using UnityEngine;

public class Opdracht2_2 : MonoBehaviour
{
    #region variables
    public enum BeweegType
    {
        Munt, Goomba, Spook
    }
    public BeweegType beweegType;

    [Header("Munt")]

    [SerializeField] private float rotationSpeed;


    [Header("Goomba")]
    [SerializeField] private float goombaSpeed;
    [SerializeField] private Vector3 goombaVector;
    #endregion

    private void Update()
    {
        switch (beweegType)
        {
            case (BeweegType.Munt):
                MuntMovement();
                break;
            case (BeweegType.Goomba):
                GoombaMovement();
                break;
        }
    }

    private void MuntMovement() => transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

    private void GoombaMovement()
    {
        float tempfloat = Mathf.Sin(Time.time);
        goombaVector = new Vector3(tempfloat * goombaSpeed, 0, 0);
        transform.position = goombaVector;
    }
}
