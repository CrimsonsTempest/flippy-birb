using UnityEngine;

[CreateAssetMenu(fileName = "CoinDecider2", menuName = "Scriptable Objects/CoinDecider2")]
public class CoinDecider2 : ScriptableObject
{
    
    int counter = 0;


    void OnEnable()
    {
     counter = 0;
    } 

    public void hit(logikascript logicScript)
    {
        Debug.Log("coin decider fired, count is " + counter);
        if (logicScript != null)
        {


            counter++;
            counter %= 10;
            if (counter != 0)
                logicScript.addscore();
            else if (counter == 0)
            {
                logicScript.addscore(10);
            }
            Debug.Log("count= " + counter);
        }
    }
}
