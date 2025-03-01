using UnityEngine;

public class pointgainscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public logikascript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logikascript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addscore();
    }
}
