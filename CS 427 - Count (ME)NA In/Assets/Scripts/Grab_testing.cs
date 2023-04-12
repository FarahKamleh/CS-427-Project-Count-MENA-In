using UnityEngine;
using System.Collections;

public class Grab_testing : MonoBehaviour
{
    public GameObject theDoor;

    bool flag = false;

    public AudioSource fall;
    
    public GameObject word1;
    public GameObject word2;
    public GameObject word3;
    public GameObject word4;
    public GameObject word5;
    public GameObject word6;
    public GameObject word7;
    public GameObject word8;

    public GameObject fall_word1;
    public GameObject fall_word2;
    public GameObject fall_word3;
    public GameObject fall_word4;

    int flag1 = 0;
    int flag2 = 0;
    int flag3 = 0;
    int flag4 = 0;
    int flag5 = 0;
    int flag6 = 0;
    int flag7 = 0;
    int flag8 = 0;

    int first_flag = 0;

    Vector3 word1_pos;
    Vector3 word2_pos;
    Vector3 word3_pos;
    Vector3 word4_pos;
    Vector3 word5_pos;
    Vector3 word6_pos;
    Vector3 word7_pos;
    Vector3 word8_pos;

    new Rigidbody rb1;
    new Rigidbody rb2;
    new Rigidbody rb3;
    new Rigidbody rb4;
    // Use this for initialization
    void Start()
    {
        rb1 = fall_word1.GetComponent<Rigidbody>();
        rb2 = fall_word2.GetComponent<Rigidbody>();
        rb3 = fall_word3.GetComponent<Rigidbody>();
        rb4 = fall_word4.GetComponent<Rigidbody>();

        theDoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(first_flag==0)
        {
            word1_pos = word1.transform.position;
            word2_pos = word2.transform.position;
            word3_pos = word3.transform.position;
            word4_pos = word4.transform.position;
            word5_pos = word5.transform.position;
            word6_pos = word6.transform.position;
            word7_pos = word7.transform.position;
            word8_pos = word8.transform.position;

            first_flag = 1;

        }

        if (word1_pos != word1.transform.position)
        {
            flag1 = 1;
        }
        if (word2_pos != word2.transform.position)
        {
            flag2 = 1;
        }
        if (word3_pos != word3.transform.position)
        {
            flag3 = 1;
        }
        if (word4_pos != word4.transform.position)
        {
            flag4 = 1;
        }
        if (word5_pos != word5.transform.position)
        {
            flag5 = 1;
        }
        if (word6_pos != word6.transform.position)
        {
            flag6 = 1;
        }
        if (word7_pos != word7.transform.position)
        {
            flag7 = 1;
        }
        if (word8_pos != word8.transform.position)
        {
            flag8 = 1;
        }
        if(flag1==1 && flag2==1 && flag3==1 && flag4==1 && flag5==1 && flag6==1 && flag7==1 && flag7==1 && flag8==1)
        {
            // another second delay
            StopCoroutine(Delay());

            rb1.useGravity = true;
            rb2.useGravity = true;
            rb3.useGravity = true;
            rb4.useGravity = true;

            if (flag == false)
            {
                // fall sound
                fall.Play();
                flag = true;
            }

            // make door appear
            theDoor.SetActive(true);

        }

    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);
    }

}
