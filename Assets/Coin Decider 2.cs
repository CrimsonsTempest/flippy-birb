using UnityEngine;

[CreateAssetMenu(fileName = "CoinDecider2", menuName = "Scriptable Objects/CoinDecider2")]
public class CoinDecider2 : ScriptableObject
{
    logikascript logicScript;
    int counter = 0;
    public bgspawn bgspawn;
    public pipespawn Pipespawn;
    public float movespeed = 5;

    void OnEnable()
    {
        counter = 0;
    }

    public void attachPspawn(pipespawn p)
    {
        Pipespawn = p;
     }
     public void attachBGspawn(bgspawn p)
    {
        bgspawn = p;
     }
    public void attachlogic(logikascript l)
    {
        logicScript = l;
    }
    public void hit()
    {
        logicScript.addscore();
        //Debug.Log("coin decider fired, count is " + counter);
        if (logicScript != null)
        {
            counter++;
            counter %= 10;

            if (counter == 0)
            {
                
            }
            //Debug.Log("count= " + counter);
        }
    }

    



}
