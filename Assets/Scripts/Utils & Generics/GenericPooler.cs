using System;
using System.Collections.Generic;

public class GenericPooler<T>: MonoSingletonGeneric<GenericPooler<T>> where T: class
{
    private class PooledItem<T>
    {
        public T poolItem;
        public bool isUsed;
    }
    public T GetPooledItem()
    {
        if(poolItemList.Count > 0)
        {
            PooledItem<T> poolObject = poolItemList.Find(i => i.isUsed == false);
            if (poolObject != null)
            {
                poolObject.isUsed = true;
                return poolObject.poolItem;
            }
            else
            {
                return CreateNewPoolItem();
            }
        }
        return CreateNewPoolItem();
    }

    public T CreateNewPoolItem()
    {
        PooledItem<T> NewPoolItem = new PooledItem<T>();
        NewPoolItem.poolItem = CreateItem();
        NewPoolItem.isUsed = true;
        poolItemList.Add(NewPoolItem);
        return NewPoolItem.poolItem;
    }

    public virtual T CreateItem()
    {
        return null;
    }

    public void ReturnItemToPool(T item)
    {
        PooledItem<T> returnPoolObject = poolItemList.Find(i => i.poolItem.Equals(item));
        returnPoolObject.isUsed = false;
    }
    private List<PooledItem<T>> poolItemList = new List<PooledItem<T>>();

}
