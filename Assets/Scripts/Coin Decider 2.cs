using UnityEngine;

[CreateAssetMenu(fileName = "CoinDecider2", menuName = "Scriptable Objects/CoinDecider2")]
public class CoinDecider2 : ScriptableObject
{
    logikascript logicScript;
    int counter = 0;
    public bgspawn bgspawn;
    public pipespawn Pipespawn;
    public float movespeed = 5;
    public float bgspawnrate = 10;
    public float PipeSpawnrate = 3;
    public float IncreaseRate = 1.05f;



    public float Rmovespeed;
    public float Rbgspawnrate;
    public float RPipeSpawnrate;
    public float RIncreaseRate;


    void reloaded()
    {
        Rmovespeed = movespeed;
        Rbgspawnrate = bgspawnrate;
        RPipeSpawnrate = PipeSpawnrate;
        RIncreaseRate = IncreaseRate;

    }

    void OnEnable()
    {
        counter = 0;
        reloaded();
    }

    public void attachlogic(logikascript l)
    {
        logicScript = l;
    }

    public void hit()
    {
        logicScript.addscore();


        counter++;
        counter %= 3;

        if (counter == 0)
        {
            Rmovespeed *= RIncreaseRate;
            Rbgspawnrate /= RIncreaseRate;
            RPipeSpawnrate /= RIncreaseRate;
            Debug.Log("Faster");
            
        }
            
        
        
    }

    



}
