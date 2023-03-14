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

        // set question inactive at start
        raceQ.SetActive(false);

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
    }

    // Update is called once per frame
    void Update()
    {
        // if user presses L1 on wand or up on keyboard
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button5)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // make the command disappear
            command.SetActive(false);

            // make everything else appear except the try anothers
            doorBAA.SetActive(true);
            doorAIAN.SetActive(true);
            doorO.SetActive(true);
            doorNHOPI.SetActive(true);
            doorW.SetActive(true);
            doorHL.SetActive(true);
            doorA.SetActive(true);
            raceQ.SetActive(true);
        }
        
    }
}
