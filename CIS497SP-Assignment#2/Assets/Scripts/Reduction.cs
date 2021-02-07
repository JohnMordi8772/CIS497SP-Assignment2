using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reduction : DamageAvoidance
{
    public override IEnumerator Avoid()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;

        yield return new WaitForSecondsRealtime(5f);

        GetComponent<MeshRenderer>().material.color = Color.gray;

        yield break;
    }
}
