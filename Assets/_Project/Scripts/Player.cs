using UnityEngine;

namespace DragonspiritGames.BreakOutClone
{
    public class Player : MonoBehaviour
    {
        Rigidbody _rigidbody;

        void Awake()
        {
            Cursor.visible = false;
            _rigidbody = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            _rigidbody.MovePosition(new Vector3(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 50)).x, -16, 0));
        }
    }
}
