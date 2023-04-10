using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScholAppL1 : MonoBehaviour
{
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

    // command game object and race question
    public GameObject command;
    public GameObject raceQ;

    // spotlight sound
    public AudioSource spotLight;

    // a flag for sound only once
    bool soundFlag = false;

    // have thoughts disappear and new ones appear
    public GameObject thoughts2;
    public GameObject thoughts3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if user presses L2 on wand or up on keyboard
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button7)) || (Input.GetKeyDown(KeyCode.UpArrow)))
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
        doorNHOPI.SetActive(true);
        doorW.SetActive(true);
        doorHL.SetActive(true);
        doorA.SetActive(true);
        raceQ.SetActive(true);
        thoughts2.SetActive(false);
        thoughts3.SetActive(true);
    }
}
