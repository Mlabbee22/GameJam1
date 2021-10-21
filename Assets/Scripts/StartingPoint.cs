using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingPoint : MonoBehaviour
{
    Scene activeScene;
    [SerializeField] Vector2 hometown;
    [SerializeField] Vector2 flatlands;
    Vector2 empty;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SavePoint(string movingScene)
    {
        activeScene = SceneManager.GetActiveScene();
        Debug.Log(activeScene.name);

        if (activeScene.name == "Begining Town")
        {
            hometown = new Vector2(-10, 9);
        }

    }

    public void LoadPoint(string movingScene)
    {
        player = GameObject.FindWithTag("Azure");

        if (movingScene == "Flatlands")
        {
            if (flatlands == empty)
            {

            }

            else
            {

            }
        }
        else if (movingScene == "Begining Town")
        {

        }
    }
}



