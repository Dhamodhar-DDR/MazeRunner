using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatekey : MonoBehaviour
{
    public AudioSource keysound;
    public GameObject key;
    public int keyg = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 150*Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        keysound.Play();
        key.SetActive(false);
        keyg = 1;
    }
}
