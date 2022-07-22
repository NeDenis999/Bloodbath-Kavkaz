using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _event.Invoke();
    }
}
