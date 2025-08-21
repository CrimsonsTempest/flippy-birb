using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem; // Add this for the new Input System

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public int jumpPower = 5;
    public logikascript logic;
    public bool birbisalive = true;


   

    void Update()
    {

        if (transform.position.y < -18)
        {
            Destroy(gameObject);
            logic.GameOver();
            Debug.Log("Birb Deleted");
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (birbisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * jumpPower;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        birbisalive = false;
        logic.GameOver();
    }

}
