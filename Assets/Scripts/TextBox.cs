using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public Text myText;
    bool wait = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Chat(float length, string convo)
    {
        if (wait == false)
        {
            myText.gameObject.SetActive(true);
            myText.text = convo;
            StartCoroutine(Wait(length));
        }

    }

    IEnumerator Wait(float time)
    {
        wait = true;
        yield return new WaitForSeconds(time);
        myText.text = "";
        wait = false;
        
    }
}
