using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void TimeDilation(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
