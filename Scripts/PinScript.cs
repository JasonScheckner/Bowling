using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
{
    public int pindow = 0;
    Rigidbody rb;
    public int IsPinDown() {
        int happensonce = 0;
        if(happensonce == 0)
        {
            if ((transform.localRotation.eulerAngles.x > 3) || (transform.localRotation.eulerAngles.z > 3))
            {
                pindow = 1;
                happensonce = 1;
            }

        }
        
        
        return pindow;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(pindow == 0)
        {
            pindow = IsPinDown();
        }

    }
}
