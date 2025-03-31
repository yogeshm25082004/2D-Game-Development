using UnityEngine;
using UnityEngine.SceneManagement;

public class options : MonoBehaviour
{
    public void OpenLevel(int LevelID)
    {
        string Levelname = "Level" + LevelID;
        SceneManager.LoadScene(Levelname);
    }

    
}
