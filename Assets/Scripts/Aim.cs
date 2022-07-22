using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = transform.position.z - Camera.main.transform.position.z; // ��� ������ ��� ������������� ������ ����������
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition); //��������� ���� �� �������� � ������� ����������
        transform.position = mousePosition;
    }
}
