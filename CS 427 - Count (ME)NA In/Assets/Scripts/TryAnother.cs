﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAnother : MonoBehaviour
{
    // identify the collider
    Collider boxCollider;

    // try another game object
    public GameObject tryAnother;

    // locked door sound
    public AudioSource locked;

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();
    }

    // if the box collides with another box, trigger
    private void OnTriggerEnter(Collider other)
    {
        // play the sound
        locked.Play();

        // delay the try another
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        // wait 1 seconds
        yield return new WaitForSeconds(2);

        // make the Try Another text appear
        tryAnother.SetActive(true);
    }
}
