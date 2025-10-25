using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            // rotate left
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            // rotate right
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}