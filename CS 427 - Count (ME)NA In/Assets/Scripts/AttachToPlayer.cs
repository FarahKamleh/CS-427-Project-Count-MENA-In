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

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();
    }

    // if a collision occurs
    private void OnTriggerEnter(Collider other)
    {
        // make skybox darker
        RenderSettings.skybox.SetFloat("_Exposure", 0.9f);

        // attach the word
        word2.SetActive(true);

        // make word disappear
        word1.SetActive(false);
    }
}
