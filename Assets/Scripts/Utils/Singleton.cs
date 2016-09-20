using UnityEngine;

/// <summary>
/// Manager scripts should extend this class to implement a singleton pattern
/// </summary>
/// <typeparam name="T">type of class implementing the singleton pattern</typeparam>
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    [HideInInspector]
    public static T instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }
        else
        {
            Debug.Log("Duplicate singletons of type: " + typeof(T));
        }
    }
}
