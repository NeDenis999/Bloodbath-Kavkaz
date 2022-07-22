using UnityEngine;

public class SlowingDownTime : MonoBehaviour
{
    public void SlowedTime() => 
        Time.timeScale = 0.1f;

    public void NormalTime() => 
        Time.timeScale = 1f;
}