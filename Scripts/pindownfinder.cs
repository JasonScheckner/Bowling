using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pindownfinder : MonoBehaviour

{
    int onlyonce = 0;

    public int howmanydown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pindowncount();
        
        









        //have to make a clause so it only happens once every time the pin falls down
    }
   
    void pindowncount()
    {
        if ((DemoScript.timeLeft == -1) && (onlyonce == 0))
        {
            for (int i = 0; i < 10; i++)
            {
                howmanydown += transform.GetChild(i).GetComponent<PinScript>().pindow;
                if(transform.GetChild(i).GetComponent<PinScript>().pindow == 1)
                {
                    Destroy(transform.GetChild(i).gameObject);
                }
            }
            onlyonce = 1;
            DemoScript.timeLeft = -2;
        }
    }
}


