using UnityEngine;

public class pointgainscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public CoinDecider2 coindecider;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        coindecider.hit();
        Destroy(gameObject);
    }
}
