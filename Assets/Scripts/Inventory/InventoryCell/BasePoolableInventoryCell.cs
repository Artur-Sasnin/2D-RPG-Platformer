﻿using ObjectPool;

public class BasePoolableInventoryCell : BaseInventoryCell, IPoolable
{
    public virtual void Spawn()
    {
        gameObject.SetActive(true);
    }

    public virtual void Release()
    {
        gameObject.SetActive(false);
    }
}