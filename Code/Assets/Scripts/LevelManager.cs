using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour

{
    public void Level0()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Level1()
    {
        if (Chest.lvl1k)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void Level2()
    {
        if (Chest.lvl2k)
        {
            SceneManager.LoadScene(4);
        }
    }
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void l12()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void lvlb()
    {
        SceneManager.LoadScene(1);
    }
}
