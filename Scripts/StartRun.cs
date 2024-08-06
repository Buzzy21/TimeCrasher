using UnityEngine;
using UnityEngine.SceneManagement;
public class StartRun : MonoBehaviour
{
    public AudioSource audioSource;
    public void StartGame()
    {
        audioSource.Play();
        SceneManager.LoadScene("Gameplay");
    }
}
