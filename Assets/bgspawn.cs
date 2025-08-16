using Unity.VisualScripting;
using UnityEngine;

public class bgspawn : MonoBehaviour
{

 public GameObject background;
    public float spawnrate=2;
    private float timer=0;
    public CoinDecider2 cd;




    void Start()
    {
        spawnbg();
        cd.attachBGspawn(this);
    }
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnbg();
            timer = 0;
        }
    }
    


 void spawnbg() {
        Vector3 a= new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(background,a,transform.rotation);
    }

}
