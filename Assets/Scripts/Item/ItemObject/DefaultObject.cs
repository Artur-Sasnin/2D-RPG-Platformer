﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Default")]
public class DefaultObject : BaseItemObject
{
    public void Awake()
    {        
        ItemData.ItemType = ItemType.Default;
    }

    public override BaseItem Equip(Transform parent)
    {        
        return null;
    }    
}
