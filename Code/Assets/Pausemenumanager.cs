using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausemenumanager : MonoBehaviour
{
    public GameObject PauseMenu;
    public bool pact = false;
    public void Resume()
    { 
        pact = false;
        PauseMenu.SetActive(false);
    }
    public void Restart()
    {
        PauseMenu.SetActive(false);
        pact = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu()
    {
        PauseMenu.SetActive(false);
        pact = false;
        SceneManager.LoadScene(0);
    }
    void Update()
    {
        if (Input.GetKey("p"))
        {
            PauseMenu.SetActive(true);
            pact = true;
        }
    }
}
