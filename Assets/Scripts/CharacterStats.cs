using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    int xp = 0;
    int level = 1;
    int damage;
    int health;
    int speed;
    int abilityCoolDown;
    string ability;
    public string name;
    bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        if (name == "Azure")
        {
            damage = 10;
            health = 30;
            speed = 5;
            abilityCoolDown = 4;
            ability = "Firebolt";
        }

        if (name == "Jimmy")
        {
            damage = 7;
            health = 50;
            speed = 3;
            abilityCoolDown = 5;
            ability = "BARrier";

        }

        if (name == "Philip")
        {
            damage = 4;
            health = 35;
            speed = 8;
            abilityCoolDown = 3;
            ability = "Healing Fish";
        }

        if (name == "Otto")
        {
            damage = 5;
            health = 40;
            speed = 6;
            abilityCoolDown = 2;
            ability = "Gold Toss";
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
