using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Chest : MonoBehaviour
{    // Start is called before the first frame update
    public int flag;
    public GameObject keygold;
    public GameObject player;
    public GameObject Win;
    public GameObject Map;
    public AudioSource chestaudio;
    public float t = 9000;
    public static bool lvl1k = false;
    public static bool lvl2k = false;
    void Start()
    {
        GameObject keygold = GameObject.Find("key_gold");
        rotatekey cs = keygold.GetComponent<rotatekey>();
        flag = cs.keyg;
    }

    // Update is called once per frame
    void Update()
    {
   
        float d1= Mathf.Abs(player.transform.position[0]-transform.position[0]);
        float d2 = Mathf.Abs(player.transform.position[2] - transform.position[2]);
        flag = keygold.GetComponent<rotatekey>().keyg;
        if (Input.GetKey("e") && flag == 1 && d1 <= 3 && d2<=3)
        {
            t = Time.time;
            lvl1k = true;
            GetComponent<Animator>().enabled = true;
            chestaudio.Play();
            int a = SceneManager.GetActiveScene().buildIndex;
            if (a == 3)
            {
                lvl2k = true;
            }
            
        }
        if (Time.time >= t + 2)
        {
            Win.SetActive(true);
            Map.SetActive(false);

        }
    }
}
