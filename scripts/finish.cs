using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    [SerializeField] AudioSource finishAudio;

    private void OnTriggerEnter2D(Collider2D other)
    
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("NextLevel", 1.25f);
            finishAudio.Play();
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
   
