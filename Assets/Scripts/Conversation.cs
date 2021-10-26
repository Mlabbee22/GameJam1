using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    public bool party;
    public string convo;
    public float length;
    GameObject holder;
    GameObject convobox;
    GameObject character;



    // Start is called before the first frame update
    void Start()
    {
        convobox = GameObject.FindWithTag("TextBox");
        holder = GameObject.FindWithTag("GameController");
        character = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (convobox == null)
            GameObject.FindWithTag("TextBox");
    }

    public void Talk()
    {
        convobox.GetComponent<TextBox>().Chat(length, convo);
    }

    public void Party()
    {
        if (party == true)
        {
            holder.GetComponent<Party>().JoinParty(character);
            gameObject.SetActive(false);
        }
    }

}
