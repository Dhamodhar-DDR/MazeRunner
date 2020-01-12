using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvmntL1 : MonoBehaviour
{
    public Rigidbody player;
    public Transform cm;
    public int a, b, c;
    RaycastHit vision;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        float xDirection = Input.GetAxis("Mouse X");
        float yDirection = Input.GetAxis("Mouse Y");
        cm.Rotate(-yDirection, 0, 0);
        transform.Rotate(0, xDirection, 0);
        if (Input.GetKey("d"))
        {
            player.AddForce(5000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, -5000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("w"))
        {
            player.AddForce(5000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, 5000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("a"))
        {
            player.AddForce(-5000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0, +5000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        if (Input.GetKey("s"))
        {
            player.AddForce(-5000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI/180.0f)), 0, -5000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        }
        else
        {
            
        }
     /*   Vector3 forward = new Vector3(-1000 * Time.deltaTime * Mathf.Sin(transform.eulerAngles.y * (Mathf.PI / 180.0f)), 0 , -1000 * Time.deltaTime * Mathf.Cos(transform.eulerAngles.y * (Mathf.PI / 180.0f)));
        Vector3 initial = new Vector3(transform.position[0], transform.position[1]+0.2f, transform.position[2]);*/
        //Debug.DrawLine(initial, forward, Color.yellow,0.5f);
        //Physics.Raycast(initial, forward, out vision);
/*        Debug.Log(vision.collider.gameObject.name);
*/     
    }
}