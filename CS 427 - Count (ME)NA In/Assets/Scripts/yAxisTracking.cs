using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yAxisTracking : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // fetch rotation of head tracking
        Vector3 headRotation = CAVE2.GetHeadRotation(1).eulerAngles;

        // apply y rotation to cube
        this.transform.localEulerAngles = new Vector3(0, headRotation.y, 0);
    }
}
