using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1 : MonoBehaviour
{
    public GameObject REPLAY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Lvl1()
    {
        SceneManager.LoadScene("Level1");
    }
}
