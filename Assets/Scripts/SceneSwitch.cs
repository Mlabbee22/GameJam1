using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string scene;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Azure")
        {
            gameObject.GetComponent<StartingPoint>().SavePoint(scene);
            SceneManager.LoadScene(scene);
        }

        gameObject.GetComponent<StartingPoint>().LoadPoint(scene);


    }
}