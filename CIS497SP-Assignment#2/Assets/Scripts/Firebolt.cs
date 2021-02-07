using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebolt : SpellAttack
{
    public override void Cast()
    {
        Instantiate(Resources.Load("Fireball"), gameObject.transform.position, gameObject.transform.rotation);

    }
}
