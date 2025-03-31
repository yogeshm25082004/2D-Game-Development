using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField] Text finalScoreText; // UI Text to show final score

    void Start()
    {
        // Retrieve the total collected kiwi count (across both Level 1 and Level 2)
        int totalKiwi = PlayerPrefs.GetInt("KiwiCount", 0); // Load saved score (default 0)

        // Display the total kiwi score in the UI Text
        finalScoreText.text = "YOUR SCORE: " + totalKiwi;
    }

        public void ResetScore()
    {
        PlayerPrefs.DeleteKey("KiwiCount"); // Reset score
                                            // Or use PlayerPrefs.DeleteAll() to clear all data
    }

}

