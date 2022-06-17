using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puzzletrigger : MonoBehaviour
{
    public UnityEvent OnEnterArea;
    public UnityEvent OnExitArea;


    private void OnTriggerEnter(Collider other)
    {
        OnEnterArea.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        OnExitArea.Invoke();
    }
}
