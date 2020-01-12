using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCanv : MonoBehaviour
{
    public Transform player;
    RaycastHit vision;
    public GameObject wincanv;
    void Update()
    {
        Vector3 forward = new Vector3(-1000 * Time.deltaTime * Mathf.Sin(player.eulerAngles.y * (Mathf.PI / 180.0f)), 0, -1000 * Time.deltaTime * Mathf.Cos(player.eulerAngles.y * (Mathf.PI / 180.0f)));
        Vector3 initial = new Vector3(player.position[0], player.position[1] + 0.2f, player.position[2]);
        Physics.Raycast(initial, forward, out vision);
        if (vision.collider.gameObject.name == "check")
        {
            if (vision.distance <= 5)
            {
                wincanv.SetActive(true);
                Time.timeScale = 1.0f;
            }
        }
    }
}
