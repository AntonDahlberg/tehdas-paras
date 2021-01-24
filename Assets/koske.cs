using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koske : MonoBehaviour
{
    public GameObject seinan;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "seina")
        {
            seinan.gameObject.SetActive(false);
            

        }
    }

}
