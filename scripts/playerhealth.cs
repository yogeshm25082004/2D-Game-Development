using UnityEngine;
using UnityEngine.SceneManagement;
public class playerhealth : MonoBehaviour
{
    Animator animator;
    [SerializeField] AudioSource deathAudio;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "trap")
        {
            animator.SetTrigger("death");
            GetComponent<playermovement>().enabled = false;
            deathAudio.Play();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
