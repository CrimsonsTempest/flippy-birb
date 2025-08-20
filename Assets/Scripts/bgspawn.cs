using Unity.VisualScripting;
using UnityEngine;

public class bgspawn : MonoBehaviour
{

 public GameObject background;
    
    private float timer=0;
    public CoinDecider2 cd;




    void Start()
    {
        spawnbg();
        
    }
    void Update()
    {
        if (timer < cd.Rbgspawnrate)
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
