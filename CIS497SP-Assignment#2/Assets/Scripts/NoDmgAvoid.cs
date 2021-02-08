/*
 * John Mordi
 * NoDmgAvoid.cs
 * Assignment 2 
 * Some characters might not implement a type of damage avoidance
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDmgAvoid : DamageAvoidance
{
    public override IEnumerator Avoid()
    {
        yield break;
    }
}
