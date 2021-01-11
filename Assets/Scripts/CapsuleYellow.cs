using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapsuleYellow : MonoBehaviour
{
    public GameObject YellowText;
    public int yellowCounter;

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
        if (other.gameObject.tag == "Player")
        {
            yellowCounter++;

            YellowText.GetComponent<Text>().text = "Yellow: " + yellowCounter;

            audioSource.Play();
        }
    }
}
