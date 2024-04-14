using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public Spawner spawner;

    public static bool finished = false;

    //public static int level = 1;

    public GameObject winPanel;
    public GameObject losePanel;

    //private void Awake()
    //{
    //    level = PlayerPrefs.GetInt("level", 1);
    //}

    private void Start()
    {
        finished = false;
    }

    private void Update()
    {
        if (finished == false)
        {
            Check();
        }
    }

    public void Check()
    {
        if (spawner.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();

            if (enemies.Length <= 0)
            {
                Victory();

            }
        }

        if (Corn.singleton.health <= 0)
        {
            Defeat();
        }
    }

    public void Victory()
    {
        finished = true;
        //level += 1;
        winPanel.SetActive(true);

        GameController.level++;
        GameController.SaveLevel();

        //PlayerPrefs.SetInt("level", level);
    }

    public void Defeat()
    {
        finished = true;
        losePanel.SetActive(true);
    }

    public void RestartLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}