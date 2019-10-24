using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_Bow : I_Equipment
{
    [Header("Bow Stats")]
    [Range(1, 11)]
    public float range = 6;

    [Range(1, 11)]
    public float damage = 6;
}
