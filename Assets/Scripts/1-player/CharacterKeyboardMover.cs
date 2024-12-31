using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.UI;


/**
 * This component moves a player controlled with a CharacterController using the keyboard.
 */
[RequireComponent(typeof(CharacterController))]
public class CharacterKeyboardMover : MonoBehaviour
{
    [Tooltip("Speed of player keyboard-movement, in meters/second")]
    [SerializeField] float speed = 3.5f;
    [SerializeField] float gravity = 9.81f;

    private CharacterController cc;

    [SerializeField] InputAction moveAction;


    [SerializeField] InputAction jumpAction;
    [SerializeField] float jumpSpeed = 10f;
    [SerializeField] float slowDownAtJump = 0.5f;

    private void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }
    private void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }
    void OnValidate()
    {
        // Provide default bindings for the input actions.
        // Based on answer by DMGregory: https://gamedev.stackexchange.com/a/205345/18261
        if (moveAction == null)
            moveAction = new InputAction(type: InputActionType.Button);
        if (moveAction.bindings.Count == 0)
            moveAction.AddCompositeBinding("2DVector")
                .With("Up", "<Keyboard>/upArrow")
                .With("Down", "<Keyboard>/downArrow")
                .With("Left", "<Keyboard>/leftArrow")
                .With("Right", "<Keyboard>/rightArrow");

        if (jumpAction == null)
            jumpAction = new InputAction(type: InputActionType.Button);
        if (jumpAction.bindings.Count == 0)
            jumpAction.AddBinding("<Keyboard>/space");
    }

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    Vector3 velocity = new Vector3(0, 0, 0);
    void Update()
    {
        // Get movement input
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 inputVelocity = new Vector3(input.x, 0, input.y) * speed;

        if (cc.isGrounded)
        {
            // Update horizontal velocity when grounded
            velocity.x = inputVelocity.x;
            velocity.z = inputVelocity.z;

            // Handle jump
            if (jumpAction.WasPressedThisFrame())
            {
                velocity.y = jumpSpeed; // Apply vertical jump velocity
                velocity.x *= slowDownAtJump;
                velocity.z *= slowDownAtJump;
            }
        }
        else
        {
            // Apply gravity when airborne
            velocity.y -= gravity * Time.deltaTime;
        }

        // Move in the direction you look:
        Vector3 move = transform.TransformDirection(velocity);
        cc.Move(move * Time.deltaTime);
    }
}
