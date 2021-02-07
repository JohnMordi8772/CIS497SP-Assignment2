using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockThrow : SpellAttack
{
    public override void Cast()
    {
        Instantiate(Resources.Load("Rock"), gameObject.transform.position, gameObject.transform.rotation);
    }
}
