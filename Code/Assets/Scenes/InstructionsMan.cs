using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsMan : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
