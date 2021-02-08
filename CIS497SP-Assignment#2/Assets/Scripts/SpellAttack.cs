/*
 * John Mordi
 * SpellAttack.cs
 * Assignment 2 
 * Parent class for spell attacks to allow for polymorphism
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellAttack: MonoBehaviour
{
    public abstract void Cast();
}
