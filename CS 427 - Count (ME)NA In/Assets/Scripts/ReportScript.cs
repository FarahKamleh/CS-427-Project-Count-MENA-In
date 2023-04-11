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

    // Start is called before the first frame update
    void Start()
    {
        // ensure cannot is inactive
        cannot.SetActive(false);
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
    }
}
