using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger_UnityEvents : MonoBehaviour
{

    [SerializeField]
    private UnityEvent onEnter;
    [SerializeField]
    private UnityEvent onExit;
    [SerializeField]
    private string colliderName;

    private void OnTriggerEnter(Collider other)
    {

       
        if (other.name == colliderName)
        {
            Debug.Log(other.name);
            onEnter.Invoke();
        }
            

    }

    private void OnTriggerExit(Collider other)
    {

        Debug.Log(other.name);

        if (other.name == colliderName)
            onExit.Invoke();

    }

}
