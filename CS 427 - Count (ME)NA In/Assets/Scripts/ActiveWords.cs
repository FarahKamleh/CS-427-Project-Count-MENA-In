using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveWords : MonoBehaviour
{
    new Rigidbody rigidbody;
    public GameObject text;

    // Use this for initialization
    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (text.active)
        {
            rigidbody.isKinematic = false;
            DetachFromParent();
        }
    }

    public void DetachFromParent()
    {
        transform.parent = null;
    }
}
