using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoScript : MonoBehaviour
{
    public int xrotation;
    public int zrotation;
    public bool pindow;
    public float speed = 0f;
    Rigidbody rb;
    int setXpos = 0;
    public static float timeLeft = 5.0f;
    int once = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.GetKey(KeyCode.UpArrow) && setXpos == 0) {
            rb.AddForce(0, 0, (speed * -1), ForceMode.Impulse);
            setXpos = 1;
        }


        if (setXpos == 0) {
            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(0.01f, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.Translate(-0.01f, 0, 0);
            }

        }
        Timer();
        if((timeLeft == -1) && (once == 0))
        {
            transform.position = (new Vector3(0f, 0.5f, 22.62f));
            rb.velocity = Vector3.zero;
            rb.Sleep();
            once = 1;
            setXpos = 0;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }

    }
    void Timer()
    {
        if ((setXpos == 1) && (timeLeft >= 0))
        {
            timeLeft -= Time.deltaTime;

        }
        if (timeLeft <= 0)
        {
            timeLeft = -1;
        }
    }

}
