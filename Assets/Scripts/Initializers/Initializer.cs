using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Initializer : MonoBehaviour
{
    [SerializeField] List<MonoInitializer> initializerList;

    [SerializeField] UnityEvent OnBeforeInitialize;
    [SerializeField] UnityEvent OnAfterInitialize;
    public void Init()
    {
        OnBeforeInitialize.Invoke();
        initializerList.ForEach(initializer => initializer.Init());
        OnAfterInitialize.Invoke();
    }
}

public abstract class MonoInitializer : MonoBehaviour
{
    public abstract void Init();
}
