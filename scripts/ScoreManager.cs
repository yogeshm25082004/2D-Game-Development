using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int score;

    void Start()
    {
        // Load the previous score if it exists
        score = PlayerPrefs.GetInt("TotalScore", 0);
    }

    // Call this function to add score
    public void AddScore(int points)
    {
        score += points;
        PlayerPrefs.SetInt("TotalScore", score);  // Save the updated score
    }

    // Call this to get the total score
    public int GetTotalScore()
    {
        return score;
    }

    // You can reset the score (e.g., at the start of a new game)
    public void ResetScore()
    {
        score = 0;
        PlayerPrefs.SetInt("TotalScore", score);
    }

    // Call this to load another scene
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
