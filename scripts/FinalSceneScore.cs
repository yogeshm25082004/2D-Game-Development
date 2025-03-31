using UnityEngine;
using UnityEngine.UI;

public class FinalSceneScore : MonoBehaviour
{
    public Text TotalScoreText; // UI Text component to display the score

    void Start()
    {
        // Load the scores from PlayerPrefs
        int scene1Score = PlayerPrefs.GetInt("Kiwi", 0);  // Scene 1 score (key "Kiwi")
        int scene2Score = PlayerPrefs.GetInt("Kiwi", 0); // Scene 2 score (key "Kiwi")

        // Calculate the total score
        int totalScore = scene1Score + scene2Score;

        // Display the total score on the UI Text
        TotalScoreText.text = "YOUR SCORE: " + totalScore.ToString();

    }
    // You can also create a function that resets the score if called
    public void ResetScores()
    {
        PlayerPrefs.DeleteKey("Scene1Score");
        PlayerPrefs.DeleteKey("Scene2Score");
        PlayerPrefs.Save();
    }
}
