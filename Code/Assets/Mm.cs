using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mm : MonoBehaviour
{
    public Rigidbody player;
    public GameObject run;
    public GameObject idle;
    public Transform cm;
    public GameObject key;
    public Animation chest;
    bool countw, counts;
    void Start()
    {
        countw = false;
        counts = false;
    }
    void Update()
    {
        
        float xDirection = Input.GetAxis("Mouse X");
        float yDirection = Input.GetAxis("Mouse Y");
        transform.Rotate(0, xDirection, 0);
        cm.Rotate(-yDirection, 0, 0);
        if (Input.GetKey("w") || Input.GetKey("s"))
        {
            if (Input.GetKey("w"))
            {
                countw = true;
                counts = false;
                idle.SetActive(false);
                run.SetActive(true);
                player.velocity = new Vector3(200 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, -200 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
            } 
            if (Input.GetKey("s"))
            {
                counts = true;
                countw = false;
                idle.SetActive(false);
                run.SetActive(true);
                player.velocity = new Vector3(-200 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, +200 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
            }
        }
        else
        {
            idle.SetActive(true);
            run.SetActive(false);
        }
    }
}
