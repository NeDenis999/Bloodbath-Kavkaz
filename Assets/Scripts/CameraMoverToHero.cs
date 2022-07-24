using Heroes;
using UnityEngine;

public class CameraMoverToHero : MonoBehaviour
{
    [SerializeField] 
    private Hero _hero;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var position = _hero.transform.position;
        position.z = -10;
        transform.position = position;
    }
}