using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportScript : MonoBehaviour
{
    // command and reply
    public GameObject report;
    public GameObject cannot;

    // buzzer audio
    public AudioSource buzzer;

    // sound flag
    bool soundFlag = false;

    // thoughts
    public GameObject thoughts5;
    public GameObject thoughts6;

    // FIXME: remove
    // public GameObject comPath;
    // public GameObject comCirc;

    // wall
    public GameObject powerless;
    public GameObject hopeless;
    public GameObject helpless;
    public GameObject alone;

    // Start is called before the first frame update
    void Start()
    {
        // ensure cannot is inactive
        cannot.SetActive(false);

        // set wall inactive
        powerless.SetActive(false);
        hopeless.SetActive(false);
        helpless.SetActive(false);
        alone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if L2 or up is pressed, claim they cant report and have typography fall from the sky
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button7)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // remove the command and replace with cant report
            report.SetActive(false);

            // play the buzzer sound
            if (soundFlag == false) {
                buzzer.Play();
                soundFlag = true;
            }

            // delay in appearance
            StartCoroutine(Delay());

            // set skybox exposure to 0
            RenderSettings.skybox.SetFloat("_Exposure", 0);
        }
    }

    IEnumerator Delay()
    {
        // wait 1 seconds
        yield return new WaitForSeconds(1);

        // make message appear delayed
        cannot.SetActive(true);

        // change thoughts
        thoughts5.SetActive(false);
        thoughts6.SetActive(true);

        // wait until removal
        yield return new WaitForSeconds(6);

        // remove response
        cannot.SetActive(false);
        yield return new WaitForSeconds(1);

        // make wall appear
        powerless.SetActive(true);
        yield return new WaitForSeconds(1);
        hopeless.SetActive(true);
        yield return new WaitForSeconds(1);
        helpless.SetActive(true);
        yield return new WaitForSeconds(1);
        alone.SetActive(true);


        // FIXME: remove
        //comPath.SetActive(true);
        //comCirc.SetActive(true);
    }
}
