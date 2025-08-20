using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logikascript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public CoinDecider2 coinDecider2;
    void Start()
    {
        Application.targetFrameRate = 60;
        coinDecider2.attachlogic(this);
    }


    [ContextMenu("Increase Score")]
   public void addscore() 
    {
        playerscore = playerscore + 1;
        scoreText.text = playerscore.ToString();
    }
    
    public void addscore(int x) 
    {
        playerscore = playerscore + x;
        scoreText.text = playerscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GameOver() {
        coinDecider2.reloaded();
    GameOverScreen.SetActive(true);
    }
}
