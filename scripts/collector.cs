using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour
{
    [SerializeField] Text countText; // UI Text to show score
    [SerializeField] AudioSource coinAudio; // Audio when collecting fruit
    private int countKiwi = 0; // Track collected kiwis

    private void Start()
    {
        // Load the current kiwi count from PlayerPrefs (if any)
        countKiwi = PlayerPrefs.GetInt("KiwiCount", 0); // Default to 0 if not set
        countText.text = "Kiwi: " + countKiwi; // Update the UI text
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("fruit")) // Check if we hit a fruit
        {
            coinAudio.Play(); // Play sound
            countKiwi++; // Increment score
            countText.text = "Kiwi: " + countKiwi; // Update the score UI

            // Save the score to PlayerPrefs
            PlayerPrefs.SetInt("KiwiCount", countKiwi);

            // Destroy the fruit object
            Destroy(other.gameObject);
        }
    }
}
