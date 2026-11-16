using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float mouseSensitivity = 0.1f;

    private CharacterController controller;
    private Transform playerCamera;
    private float verticalRotation;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerCamera = GetComponentInChildren<Camera>().transform;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Keyboard.current == null || Mouse.current == null)
            return;

        //WASD
        float x = 0f;
        float z = 0f;

        if (Keyboard.current.wKey.isPressed) z += 1f;
        if (Keyboard.current.sKey.isPressed) z -= 1f;
        if (Keyboard.current.aKey.isPressed) x -= 1f;
        if (Keyboard.current.dKey.isPressed) x += 1f;

        Vector3 movement = transform.right * x + transform.forward * z;
        movement = movement.normalized;

        controller.SimpleMove(movement * moveSpeed);

        //LIBERTAR MOUSE ESQ
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        //MOUSE TO LOCK AROUND
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Vector2 mouse = Mouse.current.delta.ReadValue();

            transform.Rotate(0f, mouse.x * mouseSensitivity, 0f);

            verticalRotation -= mouse.y * mouseSensitivity;
            verticalRotation = Mathf.Clamp(verticalRotation, -80f, 80f);

            playerCamera.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
        }
    }
}
