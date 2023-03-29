using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlayer : MonoBehaviour
{
    // identify the collider
    Collider boxCollider;

    // the word to be removed and attached
    public GameObject word1;
    public GameObject word2;

    // flag materials
    public Material flagMaterial1;
    public Material flagMaterial2;
    public Material flagMaterial3;
    public Material flagMaterial4;
    public Material flagMaterial5;
    public Material flagMaterial6;
    public Material flagMaterial7;
    public Material flagMaterial8;

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();

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

    // if a collision occurs
    private void OnTriggerEnter(Collider other)
    {
        // make skybox darker
        RenderSettings.skybox.SetFloat("_Exposure", (RenderSettings.skybox.GetFloat("_Exposure") - 0.1f));

        // attach the word
        word2.SetActive(true);

        // make word disappear
        word1.SetActive(false);

        // change the opacity of the flags by 0.25
        Color color1 = flagMaterial1.color;
        color1.a = color1.a - 0.25f;
        flagMaterial1.color = color1;

        Color color2 = flagMaterial2.color;
        color2.a = color2.a - 0.25f;
        flagMaterial2.color = color2;

        Color color3 = flagMaterial3.color;
        color3.a = color3.a - 0.25f;
        flagMaterial3.color = color3;

        Color color4 = flagMaterial4.color;
        color4.a = color4.a - 0.25f;
        flagMaterial4.color = color4;

        Color color5 = flagMaterial5.color;
        color5.a = color5.a - 0.25f;
        flagMaterial5.color = color5;

        Color color6 = flagMaterial6.color;
        color6.a = color6.a - 0.25f;
        flagMaterial6.color = color6;

        Color color7 = flagMaterial7.color;
        color7.a = color7.a - 0.25f;
        flagMaterial7.color = color7;

        Color color8 = flagMaterial8.color;
        color8.a = color8.a - 0.25f;
        flagMaterial8.color = color8;
    }
}
