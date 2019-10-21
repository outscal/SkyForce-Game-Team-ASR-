using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventServices : MonoSingletonGeneric<EventServices>
{
    public static event Action KillCounter;
    public static void InitializeKillCounter() => KillCounter.Invoke();
}
