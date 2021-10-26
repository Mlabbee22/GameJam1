using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string scene;
    GameObject gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = GameObject.FindWithTag("GameController");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Azure")
        {
            gamemanager.GetComponent<StartingPoint>().LoadPoint(scene);
            SceneManager.LoadScene(scene);
        }
    }
}
