using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go2 : MonoBehaviour
{
    public bool back;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(!back)
        {
            transform.Rotate (Vector3.forward * 900 * Time.deltaTime);
            if(timer >= 3)
            {
                back = true;
                timer = 0;
            }
        }
        else if (back)
        {
            transform.Rotate (Vector3.forward * -900 * Time.deltaTime);
            if(timer >= 3)
            {
                back = false;
                timer = 0;
            }

        }
    }
}