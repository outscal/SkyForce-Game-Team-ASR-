using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>
{
    private static T instance;
<<<<<<< HEAD
    public static T Instance { get { return instance; } }
    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = (T)this;
        }
        else
        {
            Destroy(this);
        }
    }
}
=======
    public static T Instance{get{return instance;}}

    private void Awake(){
    if(instance == null)
    instance = (T)this;
    else
    {
        Debug.Log("Someone Trying to Duplicate Singleton");
        Destroy(this);
    }

    }


}
>>>>>>> a536b70234f1121969de07c33b39666fb06ef0b7
