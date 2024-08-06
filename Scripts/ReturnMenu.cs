using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnMenu : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene("FakeMenu");
    }
}
