﻿/*
 * John Mordi
 * Tank.cs
 * Assignment 2 
 * Presets for Tank characters
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : PlayerCharacters
{
    // Start is called before the first frame update
    void Awake()
    {
        dmgAvoidBehavior = gameObject.AddComponent<Reduction>();
        spellAttackbehavior = gameObject.AddComponent<RockThrow>();
    }
}
