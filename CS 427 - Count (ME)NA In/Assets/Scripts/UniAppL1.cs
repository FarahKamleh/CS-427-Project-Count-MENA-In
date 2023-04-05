using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniAppL1 : MonoBehaviour
{
    // door game objects
    public GameObject doorBAA;
    public GameObject doorAIAN;
    public GameObject doorO;
    public GameObject doorNHOPI;
    public GameObject doorW;
    public GameObject doorHL;
    public GameObject doorA;

    // try another game objects
    public GameObject tryBAA;
    public GameObject tryAIAN;
    public GameObject tryNHOPI;
    public GameObject tryW;
    public GameObject tryHL;
    public GameObject tryA;

    // command game object and race question
    public GameObject command;
    public GameObject raceQ;

    // all other paths
    public GameObject otherPath;
    public GameObject scholApp;
    public GameObject whitePath;
    public GameObject reportCirc;
    public GameObject commPath;
    public GameObject finalCirc;

    // spotlight sound
    public AudioSource spotLight;

    // character thoughts
    public GameObject thoughts1;
    public GameObject thoughts2;

    // attached words
    public GameObject word1;
    public GameObject word2;
    public GameObject word3;
    public GameObject word4;

    // a flag for sound only once
    bool soundFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        // none of the doors should be visible
        doorBAA.SetActive(false);
        doorAIAN.SetActive(false);
        doorO.SetActive(false);
        doorNHOPI.SetActive(false);
        doorW.SetActive(false);
        doorHL.SetActive(false);
        doorA.SetActive(false);

        // set question and thoughts inactive at start
        raceQ.SetActive(false);
        thoughts1.SetActive(false);
        thoughts2.SetActive(false);

        // set the try anothers inactive
        tryBAA.SetActive(false);
        tryAIAN.SetActive(false);
        tryNHOPI.SetActive(false);
        tryW.SetActive(false);
        tryHL.SetActive(false);
        tryA.SetActive(false);

        // set paths inactive
        otherPath.SetActive(false);
        scholApp.SetActive(false);
        whitePath.SetActive(false);
        reportCirc.SetActive(false);
        commPath.SetActive(false);
        finalCirc.SetActive(false);

        // make sure attached words are not visible
        word1.SetActive(false);
        word2.SetActive(false);
        word3.SetActive(false);
        word4.SetActive(false);

        // make sure spotlight sound is not playing
        spotLight.Stop();

        // ensure skybox is bright at start
        RenderSettings.skybox.SetFloat("_Exposure", 1);
    }

    // Update is called once per frame
    void Update()
    {
        // if user presses L1 on wand or up on keyboard
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button5)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // make the command disappear
            command.SetActive(false);

            // play the spotlight sound
            if (soundFlag == false)
            {
                spotLight.Play();
                soundFlag = true;
            }

            // create a delay before the doors appear
            StartCoroutine(Delay());
        }
        
    }

    IEnumerator Delay()
    {
        // wait 0.5 seconds
        yield return new WaitForSeconds(0.5f);

        // make everything else appear except the try anothers
        doorBAA.SetActive(true);
        doorAIAN.SetActive(true);
        doorO.SetActive(true);
        doorNHOPI.SetActive(true);
        doorW.SetActive(true);
        doorHL.SetActive(true);
        doorA.SetActive(true);
        raceQ.SetActive(true);
        thoughts1.SetActive(true);
    }
}
