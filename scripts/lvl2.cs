using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl2 : MonoBehaviour
{
    public GameObject REPLAY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Lvl2()
    {
        SceneManager.LoadScene("Level2");
    }
}
