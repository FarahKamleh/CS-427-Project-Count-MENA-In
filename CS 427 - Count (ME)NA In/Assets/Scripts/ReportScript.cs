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
    public AudioSource appear;
    public AudioSource hope;

    // audio
    public AudioSource heart;
    public AudioSource eerie;

    // sound flag
    bool soundFlag = false;

    // thoughts
    public GameObject thoughts5;
    public GameObject thoughts6;

    // wall
    public GameObject powerless;
    public GameObject hopeless;
    public GameObject helpless;
    public GameObject alone;

    // other typography
    public GameObject toss;
    public GameObject beenThere;
    public GameObject feel;
    public GameObject happened;
    public GameObject relate;
    public GameObject same;
    public GameObject notAlone;

    // door
    public GameObject theDoor;

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

        // inactive
        toss.SetActive(false);
        beenThere.SetActive(false);
        feel.SetActive(false);
        happened.SetActive(false);
        relate.SetActive(false);
        same.SetActive(false);
        notAlone.SetActive(false);
        theDoor.SetActive(false);
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

                // delay in appearance
                StartCoroutine(Delay());

                // set skybox exposure to 0
                RenderSettings.skybox.SetFloat("_Exposure", 0);

                // make sure only happens once
                soundFlag = true;
            }

        }

        // backup for door
        if ((soundFlag == true) && (CAVE2.GetButtonDown(CAVE2.Button.Button5)) || (Input.GetKeyDown(KeyCode.DownArrow)))
        {
            theDoor.SetActive(true);
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

        // remove response and thoughts
        thoughts6.SetActive(false);
        cannot.SetActive(false);
        yield return new WaitForSeconds(1);

        // make wall appear
        appear.Play();
        yield return new WaitForSeconds(0.5f);
        powerless.SetActive(true);
        yield return new WaitForSeconds(1);
        appear.Play();
        yield return new WaitForSeconds(0.5f);
        hopeless.SetActive(true);
        yield return new WaitForSeconds(1);
        appear.Play();
        yield return new WaitForSeconds(0.5f);
        helpless.SetActive(true);
        yield return new WaitForSeconds(1);
        appear.Play();
        yield return new WaitForSeconds(0.5f);
        alone.SetActive(true);
        

        // let hopeful music play
        eerie.Stop();
        yield return new WaitForSeconds(1);
        heart.Stop();
        yield return new WaitForSeconds(1);
        hope.Play();

        // one by one supporting words appear
        yield return new WaitForSeconds(3);
        beenThere.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));
        yield return new WaitForSeconds(3);
        feel.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));
        yield return new WaitForSeconds(3);
        happened.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));
        yield return new WaitForSeconds(3);
        relate.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));
        yield return new WaitForSeconds(3);
        same.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));
        yield return new WaitForSeconds(3);
        notAlone.SetActive(true);
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") + 0.15f));

        // command to toss words
        yield return new WaitForSeconds(3);
        toss.SetActive(true);

        // play rooting audio

    }
}
