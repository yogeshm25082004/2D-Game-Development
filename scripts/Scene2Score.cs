using UnityEngine;

public class Scene2Score : MonoBehaviour
{
    public int Kiwi = 0;

    void Start()
    {
        // Load the score from PlayerPrefs if it exists
        Kiwi = PlayerPrefs.GetInt("Kiwi", 0);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player collects a score item (for example, a coin)
        if (other.CompareTag("fruit"))
        {
            // Increase the score
            Kiwi += 1; // Adjust the score increment as needed

            // Save the updated score to PlayerPrefs
            PlayerPrefs.SetInt("Kiwi", Kiwi);

            // Destroy the collectible item
            Destroy(other.gameObject);
        }
    }
}
