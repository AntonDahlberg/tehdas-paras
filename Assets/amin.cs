using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amin : MonoBehaviour
{
    
    
    public bool aimina = false;
    public bool aimin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        aimbot();
        aiminaVoid();
        

    }
    public void aimbot()
    {
       
        if (Input.GetButtonDown("Fire2"))
        {
            aimin = !aimin;
            aimina = true;


        }
    }

    public void aiminaVoid()
    {
        if (!aimin)
        {
            if (aimina)
            {
                Vector3 temp = transform.localPosition;
                temp.y = -1.89f;
                temp.x = 0.92f;
                temp.z = 1.71f;
                transform.localPosition = temp;

                if (temp.y <= -1.89f)
                {
                    temp.y = -1.89f;
                    aimina = false;
                }
            }
        }

        else if (aimin)
        {
            if (aimina)
            {
                Vector3 temp = transform.localPosition;
                temp.y = -1.74f;
                temp.x = 0.008408546f;
                temp.z = 1.2198f;
                transform.localPosition = temp;


            }
        }
    }
}
