using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneName;

    public void OnClickPlay()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
