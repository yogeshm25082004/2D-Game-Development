using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class totalscore : MonoBehaviour
{
    [SerializeField] private int KiwiCollected;
    private void OnEnable()
    {
        if (PlayerPrefs.HasKey("Kiwi"))
        {
            KiwiCollected = PlayerPrefs.GetInt("Kiwi");
        }
    }
    // Start is called before the first framê update 
    
    void Start()
    {
        KiwiCollected = 0;
    }
    public int GetKiwi()
    {
        return KiwiCollected;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fruit"))
        {
            // oh we ran into a collectible! 
            Destroy(collision.gameObject);
            KiwiCollected++;
        }
    }
    private void OnDestroy()
    {
        savePrefs();
    }
    void savePrefs()
    {
        // Set the PlayerPref of 'Coins' with the number of coins Collected 
        PlayerPrefs.SetInt("Kiwi", KiwiCollected);
        PlayerPrefs.Save();
    }
}
