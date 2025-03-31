using UnityEngine;
using UnityEngine.SceneManagement;

public class menubt: MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
