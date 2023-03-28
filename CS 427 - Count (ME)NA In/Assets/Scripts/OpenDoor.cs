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

    // FIXME: remove this later
    public GameObject whitePath;
    public GameObject reportCirc;
    public GameObject commPath;
    public GameObject finalCirc;

    // audio
    public AudioSource open;

    // have thoughts disappear and new ones appear
    public GameObject thoughts1;
    public GameObject thoughts2;

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

        // play sound once
        if (soundFlag == true)
        {
            // create a delay before the sound plays
            StartCoroutine(Delay());

            // make false
            soundFlag = false;
        }
    }

    // delay function
    IEnumerator Delay()
    {
        // wait 1 seconds
        yield return new WaitForSeconds(1);

        // play sound
        open.Play();

        // another second delay
        yield return new WaitForSeconds(1);

        // add the path and next circle
        otherPath.SetActive(true);
        scholCirc.SetActive(true);

        // make thoughts appear and disappear
        thoughts1.SetActive(false);
        thoughts2.SetActive(true);

        // FIXME: remove later
        whitePath.SetActive(true);
        reportCirc.SetActive(true);
        commPath.SetActive(true);
        finalCirc.SetActive(true);
    }
}
