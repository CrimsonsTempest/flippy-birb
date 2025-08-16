using UnityEngine;

public class Pipemovescript : MonoBehaviour
{

    public CoinDecider2 cd;
    public float deadzone = -45;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * cd.movespeed* Time.deltaTime;

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted");
        }
    }
}
