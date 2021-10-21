using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    [SerializeField] List<GameObject> characters;
    GameObject mainPlayer;
    GameObject Merchant;
    GameObject Fisherman;
    GameObject Bartender;


    // Start is called before the first frame update
    void Start()
    {
        mainPlayer = GameObject.FindWithTag("Azure");
        Merchant = GameObject.FindWithTag("Otto");
        Fisherman = GameObject.FindWithTag("Philip");
        Bartender = GameObject.FindWithTag("Jimmy");
        JoinParty(mainPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinParty(GameObject Player)
    {
        characters.Add(Player);
    }

    public void RemoveFromparty(GameObject Player)
    {
        characters.Remove(Player);
    }
}
