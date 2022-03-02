﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : BaseItemObject
{
    public void Awake()
    {
        ItemType = ItemType.Equipment;
    }
}