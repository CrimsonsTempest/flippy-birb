using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logikascript : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject GameOverScreen;

    [ContextMenu("Increase Score")]
   public void addscore() 
    {
        playerscore = playerscore + 1;
        scoreText.text = playerscore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        
    }

    public void GameOver() { 
    GameOverScreen.SetActive(true);
    }
}
