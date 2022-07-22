using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeDelaySconds = 1f;
    [SerializeField] private UnityEvent _event;

    private async void Start()
    {
        int timeDelayMilliseconds = (int)(_timeDelaySconds * 1000);

        await Task.Delay(timeDelayMilliseconds);
        _event.Invoke();
    } 
}
