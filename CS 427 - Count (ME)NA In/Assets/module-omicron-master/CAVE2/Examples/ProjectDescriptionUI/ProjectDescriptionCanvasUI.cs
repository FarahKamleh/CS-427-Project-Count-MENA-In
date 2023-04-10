using UnityEngine;
using System.Collections;

public class ProjectDescriptionCanvasUI : MonoBehaviour
{

    [SerializeField]
    GameObject canvasUIRoot = null;

    [SerializeField]
    bool fadeAfterDistance = false;

    [SerializeField]
    float minFadingDistance = 5.0f;

    float distanceFromStart;
    private Vector3 startPosition;

    [SerializeField]
    bool fadeAfterTime = false;

    [SerializeField]
    float fadeTime = 5.0f;

    float fadeTimer = 0;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromStart = Vector3.Distance(transform.position, startPosition);

        if (fadeAfterDistance && distanceFromStart >= minFadingDistance)
        {
            DisableDescription();
            fadeAfterDistance = false;
        }
        if (fadeAfterTime)
        {
            if (fadeTimer <= fadeTime)
            {
                fadeTimer += Time.deltaTime;
            }
            else
            {
                DisableDescription();
                fadeAfterTime = false;
            }

        }

        // if L2 or the up button is pressed, fade the canvas
        if ((CAVE2.GetButtonDown(CAVE2.Button.Button7)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            // fade the canvas
            DisableDescription();
        }
    }

    public void EnableDescription()
    {
        if (canvasUIRoot.GetComponent<ChildSpriteFader>())
        {
            canvasUIRoot.GetComponent<ChildSpriteFader>().FadeIn();
        }
        else
        {
            canvasUIRoot.SetActive(true);
        }  
    }

    public void DisableDescription()
    {
        if (canvasUIRoot.GetComponent<ChildSpriteFader>())
        {
            canvasUIRoot.GetComponent<ChildSpriteFader>().FadeOut();
        }
        else
        {
            canvasUIRoot.SetActive(false);
        }
    }

    public void ToggleDescription()
    {
        if (canvasUIRoot.GetComponent<ChildSpriteFader>())
        {
            canvasUIRoot.GetComponent<ChildSpriteFader>().Toggle();
        }
        else
        {
            canvasUIRoot.SetActive(!canvasUIRoot.activeSelf);
        }
    }
}
