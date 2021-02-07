using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : PlayerCharacters
{
    // Start is called before the first frame update
    void Awake()
    {
        dmgAvoidBehavior = gameObject.AddComponent<Dodge>();
        spellAttackbehavior = gameObject.AddComponent<Firebolt>();
    }
}
