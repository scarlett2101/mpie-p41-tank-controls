using UnityEngine;


public class TankMovementSimple : MonoBehaviour
{
    public float moveSpeed = 5f;    // How fast the tank moves
    public float turnSpeed = 100f;  // How fast the tank rotates

    void Update()
    {
        // Get input from keyboard
        float move = Input.GetAxis("Vertical");   // W/S or Up/Down
        float turn = Input.GetAxis("Horizontal"); // A/D or Left/Right

        // Move tank forward or backward
        transform.Translate(-Vector3.forward * move * moveSpeed * Time.deltaTime);

        // Rotate tank left or right
        transform.Rotate(Vector3.up * turn * turnSpeed * Time.deltaTime);
    }
}