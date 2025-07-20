using UnityEngine;

public class pointgainscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public CoinDecider2 coindecider;


     logikascript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logikascript>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        coindecider.hit(logic);
        Destroy(gameObject);
    }
}
