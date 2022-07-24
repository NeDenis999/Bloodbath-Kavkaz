using System;
using UnityEngine;

namespace Heroes
{
    public class SurfaceSlider : MonoBehaviour
    {
        private Vector2 _normal;
        
        public Vector3 Project(Vector2 right)
        {
            print($"right = {right }\n_normal  = {_normal}\n Vector2.Dot(right, _normal) * _normal = {Vector2.Dot(right, _normal) * _normal}\nright - Vector2.Dot(right, _normal) * _normal = {right - Vector2.Dot(right, _normal) * _normal}");
            return right - Vector2.Dot(right, _normal) * _normal;
        }

        private void OnCollisionStay2D(Collision2D collision)
        {
            _normal = collision.contacts[0].normal;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(transform.position, (Vector2)transform.position + _normal * 3);
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + Project(transform.right));
        }
    }
}
