using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonGeneric<T> where T : SingletonGeneric<T>
{
    private static T instance;
    public static T Instance{get{return instance;}}
    public SingletonGeneric()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            //UnityEngine.Object.Destroy(this);
        }
    }

}
    

