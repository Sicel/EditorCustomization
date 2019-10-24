using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Equipment List")]
public class I_EquipmentList : ScriptableObject
{
    public List<I_Equipment> equipmentList = new List<I_Equipment>();
}
