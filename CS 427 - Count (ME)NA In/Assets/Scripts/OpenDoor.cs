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
    public AudioSource hBeat;

    // typograohy
    public GameObject scholQ;

    // have thoughts disappear and new ones appear
    public GameObject thoughts1;
    public GameObject thoughts2;

    // flag to ensure sound plays once
    bool soundFlag = true;

    // flag materials
    public Material flagMaterial1;
    public Material flagMaterial2;
    public Material flagMaterial3;
    public Material flagMaterial4;
    public Material flagMaterial5;
    public Material flagMaterial6;
    public Material flagMaterial7;
    public Material flagMaterial8;

    // door game objects
    public GameObject doorBAA;
    public GameObject doorAIAN;
    public GameObject doorNHOPI;
    public GameObject doorW;
    public GameObject doorHL;
    public GameObject doorA;

    // try another game objects
    public GameObject tryBAA;
    public GameObject tryAIAN;
    public GameObject tryNHOPI;
    public GameObject tryHL;
    public GameObject tryA;

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();

        // stop animation at start
        door.GetComponent<Animator>().enabled = false;

        // get all materials
        flagMaterial1 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial2 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial3 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial4 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial5 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial6 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial7 = GetComponent<SkinnedMeshRenderer>().material;
        flagMaterial8 = GetComponent<SkinnedMeshRenderer>().material;
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

        // heart beat increase by 0.1
        hBeat.volume = hBeat.volume + 0.1f;
        hBeat.Play();

        // add the path and next circle with command
        otherPath.SetActive(true);
        scholCirc.SetActive(true);

        // none of the doors should be visible
        doorBAA.SetActive(false);
        doorAIAN.SetActive(false);
        doorNHOPI.SetActive(false);
        doorW.SetActive(false);
        doorHL.SetActive(false);
        doorA.SetActive(false);

        // set question and thoughts inactive at start
        scholQ.SetActive(false);

        // set the try anothers inactive
        tryBAA.SetActive(false);
        tryAIAN.SetActive(false);
        tryNHOPI.SetActive(false);
        tryHL.SetActive(false);
        tryA.SetActive(false);

        // start with 1 alpha
        Color color1 = flagMaterial1.color;
        color1.a = 1;
        flagMaterial1.color = color1;

        Color color2 = flagMaterial2.color;
        color2.a = 1;
        flagMaterial2.color = color2;

        Color color3 = flagMaterial3.color;
        color3.a = 1;
        flagMaterial3.color = color3;

        Color color4 = flagMaterial4.color;
        color4.a = 1;
        flagMaterial4.color = color4;

        Color color5 = flagMaterial5.color;
        color5.a = 1;
        flagMaterial5.color = color5;

        Color color6 = flagMaterial6.color;
        color6.a = 1;
        flagMaterial6.color = color6;

        Color color7 = flagMaterial7.color;
        color7.a = 1;
        flagMaterial7.color = color7;

        Color color8 = flagMaterial8.color;
        color8.a = 1;
        flagMaterial8.color = color8;

        // make thoughts appear and disappear
        thoughts1.SetActive(false);
        thoughts2.SetActive(true);
    }
}