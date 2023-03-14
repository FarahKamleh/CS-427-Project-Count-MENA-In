using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // identify the collider
    Collider boxCollider;

    // door gameobject
    public GameObject door;

    // other path and scholarship circle
    public GameObject otherPath;
    public GameObject scholCirc;

    // audio
    public AudioSource open;

    // flag to ensure sound plays once
    bool soundFlag = true;

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();

        // stop animation at start
        door.GetComponent<Animator>().enabled = false;
    }

    // if collides
    private void OnTriggerEnter(Collider other)
    {
        // open door
        door.GetComponent<Animator>().enabled = true;

        // add the path and next circle
        otherPath.SetActive(true);
        scholCirc.SetActive(true);

        // play sound once
        if (soundFlag == true)
        {
            // play sound
            open.Play();

            // make false
            soundFlag = false;
        }
    }
}
