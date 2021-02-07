using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageAvoidance: MonoBehaviour
{
    public abstract IEnumerator Avoid();
}
