using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; // Add this for the new Input System

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public int jumpPower = 5;
    public logikascript logic;
    public bool birbisalive = true;

    private PlayerInput playerInput;
    private InputAction jumpAction;

    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        if (playerInput != null)
        {
            jumpAction = playerInput.actions["Jump"];
        }
    }

    void OnEnable()
    {
        if (jumpAction != null)
            jumpAction.performed += OnJump;
    }

    void OnDisable()
    {
        if (jumpAction != null)
            jumpAction.performed -= OnJump;
    }

    void Start()
    {

    }

    void Update()
    {

        if (transform.position.y < -18)
        {
            Destroy(gameObject);
            logic.GameOver();
            Debug.Log("Birb Deleted");
        }
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        if (birbisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * jumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birbisalive = false;
        logic.GameOver();
    }

}
