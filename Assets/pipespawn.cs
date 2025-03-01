using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate=2;
    private float timer=0;
    public float height_offset = 10;
    
    void Start()
    {
        spawnpipe();
    }

    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }


    void spawnpipe() {
        float lowestpoint = transform.position.y - height_offset;
        float highestpoint = transform.position.y + height_offset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint)), transform.rotation);
    }
}
 