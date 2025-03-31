using UnityEngine;
using UnityEngine.SceneManagement;

public class replaybt : MonoBehaviour
{
    public GameObject REPLAY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
}
