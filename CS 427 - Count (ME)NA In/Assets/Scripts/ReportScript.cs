using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportScript : MonoBehaviour
{
    // command and reply
    public GameObject report;
    //public GameObject cannot;

    // buzzer audio
    public AudioSource buzzer;

    // Start is called before the first frame update
    void Start()
    {
        // ensure cannot is inactive
        //cannot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if L2 or up is pressed, claim they cant report and have typography fall from the sky
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button7)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // remove the command and replace with cant report
            report.SetActive(false);
            //cannot.SetActive(true);

            // play the buzzer sound
            buzzer.Play();

            // set skybox exposure to 0
            RenderSettings.skybox.SetFloat("_Exposure", 0);
        }
        
    }
}
