/*
 * John Mordi
 * Reduction.cs
 * Assignment 2 
 * Allows the player to reduce damage for a limited time (currently an example of how it would work)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduction : DamageAvoidance
{
    public override IEnumerator Avoid()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;

        yield return new WaitForSecondsRealtime(2f);

        GetComponent<MeshRenderer>().material.color = Color.gray;

        yield break;
    }
}
