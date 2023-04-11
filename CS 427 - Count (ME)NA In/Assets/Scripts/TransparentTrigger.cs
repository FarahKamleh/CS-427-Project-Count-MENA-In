using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentTrigger : MonoBehaviour
{
    // identify the collider
    Collider boxCollider;

    // player thoughts
    public GameObject thoughts4;
    public GameObject thoughts5;

    // Start is called before the first frame update
    void Start()
    {
        // fetch the collider
        boxCollider = GetComponent<Collider>();
    }

    // if a collision occurs
    private void OnTriggerEnter(Collider other)
    {
        // change the character's thoughts
        thoughts4.SetActive(false);
        thoughts5.SetActive(true);
    }
}
