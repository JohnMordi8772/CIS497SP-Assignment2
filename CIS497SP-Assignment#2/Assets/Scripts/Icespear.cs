/*
 * John Mordi
 * Icespear.cs
 * Assignment 2 
 * Spawns the necessary object for Icespear
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icespear : SpellAttack
{
    public override void Cast()
    {
        Instantiate(Resources.Load("Icicle"), gameObject.transform.position, gameObject.transform.rotation);
    }
}
