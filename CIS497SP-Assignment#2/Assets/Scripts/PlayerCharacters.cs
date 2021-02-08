/*
 * John Mordi
 * PlayerCharacters.cs
 * Assignment 2 
 * Implements necessary character behaviors and allows player to change to a desired behavior
 * while the game is running
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class PlayerCharacters : MonoBehaviour
{
    public SpellAttack spellAttackbehavior;
    public DamageAvoidance dmgAvoidBehavior;

    public virtual void DoAvoid()
    {
        StartCoroutine(dmgAvoidBehavior.Avoid());
    }

    public virtual void DoCast()
    {
        spellAttackbehavior.Cast();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DoCast();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoAvoid();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StopAllCoroutines();
            Destroy(GetComponent<DamageAvoidance>());
            dmgAvoidBehavior = gameObject.AddComponent<Reduction>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StopAllCoroutines();
            Destroy(GetComponent<DamageAvoidance>());
            dmgAvoidBehavior = gameObject.AddComponent<Dodge>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            StopAllCoroutines();
            Destroy(GetComponent<DamageAvoidance>());
            dmgAvoidBehavior = gameObject.AddComponent<NoDmgAvoid>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Destroy(GetComponent<SpellAttack>());
            spellAttackbehavior = gameObject.AddComponent<Firebolt>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Destroy(GetComponent<SpellAttack>());
            spellAttackbehavior = gameObject.AddComponent<Icespear>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Destroy(GetComponent<SpellAttack>());
            spellAttackbehavior = gameObject.AddComponent<RockThrow>();
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Destroy(GetComponent<SpellAttack>());
            spellAttackbehavior = gameObject.AddComponent<NoSpellAttack>();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }


}
