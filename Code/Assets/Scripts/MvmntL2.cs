using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvmntL2 : MonoBehaviour
{
    public Rigidbody player;
    public Transform cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        
        Debug.Log(transform.eulerAngles.y);
        float xDirection = Input.GetAxis("Mouse X");
        float yDirection = Input.GetAxis("Mouse Y");
        cm.Rotate(-yDirection, 0, 0);
        transform.Rotate(0, xDirection, 0);
        if (Input.GetKey("a"))
        {
            player.AddForce(1000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, -1000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(1000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, 1000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("d"))
        {
            player.AddForce(-1000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, +1000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("w"))
        {
            player.AddForce(-1000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI/180.0f)), 0, -1000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
    }
}