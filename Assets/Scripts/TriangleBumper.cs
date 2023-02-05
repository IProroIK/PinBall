using UnityEngine;

public class TriangleBumper : MonoBehaviour
{
    [SerializeField] private Vector3 _bumpDirection;
    [SerializeField] private Rigidbody2D _ball;
    [SerializeField] private float _strength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _ball.AddForce(_bumpDirection * _strength);
    }
}
