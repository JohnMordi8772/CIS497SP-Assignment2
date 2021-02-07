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
