/*
 * John Mordi
 * Dodge.cs
 * Assignment 2 
 * Allows the player to dodge attacks
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodge : DamageAvoidance
{
    public override IEnumerator Avoid()
    {
        transform.Translate(new Vector3(0, 0, 5));

        yield return new WaitForSecondsRealtime(0.25f);

        transform.Translate(new Vector3(0, 0, -5));

        yield break;
    }
}
