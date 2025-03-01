using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public int power=5;
    public logikascript logic;
    public bool birbisalive = true;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birbisalive)
        {
            myrigidbody.linearVelocity = Vector2.up * 10;
        }

        if (transform.position.y < -18)
        {
            Destroy(gameObject);
            logic.GameOver();
            Debug.Log("Birb Deleted");

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birbisalive=false;
        logic.GameOver();
    }

}
