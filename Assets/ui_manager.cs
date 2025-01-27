using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ui_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;
    public int score;
    public Text scoreText;

    [ContextMenu("Increase Score")] //allows us to directly alter score from the inspector

    public void addScore(int scoreToAdd = 1){
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
