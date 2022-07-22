using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionAim : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Transform _rotatableObject ;
    [SerializeField] private float angle = 0;

    private void Update()
    {
        Aiming();
    }

    private void Aiming()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = transform.position.z - Camera.main.transform.position.z; // это только для перспективной камеры необходимо
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //положение мыши из экранных в мировые координаты
        var angle = Vector2.Angle(Vector2.down, mousePosition - _rotatableObject.transform.position);//угол между вектором от объекта к мыше и осью х
        _rotatableObject.eulerAngles = new Vector3(0f, 0f, transform.position.x < mousePosition.x ? angle : -angle);//немного магии на последок
        //_rotatableObject.transform.eulerAngles = new Vector3(0f, 0f, angle);
        transform.localScale = new Vector3(transform.position.x < mousePosition.x ? 1 : -1, 1, 1);
    }
}
