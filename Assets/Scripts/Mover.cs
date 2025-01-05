using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;     // Movement speed
    [SerializeField] float rotationSpeed = 100f; // Rotation speed for mouse movement

    void Start()
    {
        // Optional: Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }

    void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X"); // Horizontal mouse movement
        transform.Rotate(Vector3.up * mouseX * rotationSpeed * Time.deltaTime*moveSpeed);
    }
}