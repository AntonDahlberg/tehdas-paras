using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekstiaa : MonoBehaviour
{
    public Text m_MyText;
    public GameObject tekstini;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        m_MyText.text = "open door and get key and kill enemis and open key wall you win.";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(15);
        tekstini.gameObject.SetActive(false);
    }
}
