﻿/*
 * John Mordi
 * Warrior.cs
 * Assignment 2 
 * Presets for warrior characters
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : PlayerCharacters
{
    // Start is called before the first frame update
    void Awake()
    {
        dmgAvoidBehavior = gameObject.AddComponent<NoDmgAvoid>();
        spellAttackbehavior = gameObject.AddComponent<NoSpellAttack>();
    }
}
