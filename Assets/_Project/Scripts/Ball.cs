using UnityEngine;

namespace DragonspiritGames.BreakOutClone
{
    public class Ball : MonoBehaviour
    {
        float _speed = 20f;
        Rigidbody _rigidbody;
        Vector3 _velocity;

        void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _rigidbody.velocity = Vector3.down * _speed;
        }

        void FixedUpdate()
        {
            _rigidbody.velocity = _rigidbody.velocity.normalized * _speed;
            _velocity = _rigidbody.velocity;
        }

        void OnCollisionEnter(Collision collision)
        {
            _rigidbody.velocity = Vector3.Reflect(_velocity, collision.contacts[0].normal);
        }
    }
}
