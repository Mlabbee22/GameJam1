using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingPoint : MonoBehaviour
{
    Scene activeScene;
    [SerializeField] Vector2 hometown;
    [SerializeField] Vector2 flatlandsHT;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        activeScene = SceneManager.GetActiveScene();
        hometown = new Vector2(0, -1.3f);
        flatlandsHT = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadPoint(string movingScene)
    {
        player = GameObject.FindWithTag("Azure");

        if (movingScene == "Flatlands" && activeScene.name == "Begining Town")
        {
            player.transform.position = flatlandsHT;
        }
        else if (movingScene == "Begining Town")
        {
            player.transform.position = hometown;
        }
    }
}



