using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}
