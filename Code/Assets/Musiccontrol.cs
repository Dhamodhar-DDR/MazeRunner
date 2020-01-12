using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Musiccontrol : MonoBehaviour
{
    public AudioSource audio2;
    static bool AudioBegin = false;
    public int count = 0;
    void Awake()
    {
        if (!AudioBegin)
        {
            audio2.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
    void Update()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        if (y != 5 && y != 1 && y!=0)
        { 
            audio2.Stop();
            AudioBegin = false;
        }
        if (y == 5 && y == 1)
        {
            AudioBegin = true;
            count++;
        }
        if (y == 0)
        {
            if (count != 0)
            {
                AudioBegin = true;
            }
        }

    }
}
