/*
 * John Mordi
 * Warrior.cs
 * Assignment 2 
 * Some characters might not implement spell attacks
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoSpellAttack : SpellAttack
{
    public override void Cast()
    {
    }
}
