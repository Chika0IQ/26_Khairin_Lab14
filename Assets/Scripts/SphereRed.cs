using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereRed : MonoBehaviour
{

    public GameObject RedText;
    public int redCounter;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            redCounter++;

            RedText.GetComponent<Text>().text = "Red: " + redCounter;

            audioSource.Play();
        }
    }
}
