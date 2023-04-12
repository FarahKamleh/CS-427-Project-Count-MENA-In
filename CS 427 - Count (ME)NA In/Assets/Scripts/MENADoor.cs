using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MENADoor : MonoBehaviour
{
    // identify the collider
    Collider boxCollider;

    // door
    public GameObject door;

    // community path and circle
    public GameObject comPath;
    public GameObject comCirc;

    // audio
    public AudioSource open;
    public AudioSource crowd;

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

        // make path appear
        comPath.SetActive(true);
        comCirc.SetActive(true);

        // make skybox full
        RenderSettings.skybox.SetFloat("_Exposure", 1);

        // start crowd
        yield return new WaitForSeconds(1.5f);
        crowd.Play();
    }
}
