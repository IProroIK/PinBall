using UnityEngine;
using DG.Tweening;
public class Bumper : MonoBehaviour
{
    [SerializeField] private float _bounceStrength;
    [SerializeField] private Vector3 _minScale;
    [SerializeField] private Vector3 _maxScale;
    [SerializeField] private float _animDuration;
    [SerializeField] private Rigidbody2D _ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartBumpAnim();
        Bump(collision);
    }

    private void StartBumpAnim()
    {
        Sequence bumpAnim = DOTween.Sequence();
        bumpAnim.Append(transform.DOScale(_maxScale, _animDuration))
            .Append(transform.DOScale(_minScale, _animDuration));
    }

    private void Bump(Collision2D collision)
    {
        _ball.AddForce(collision.GetContact(0).normal * (-_bounceStrength), ForceMode2D.Impulse);

    }
    
}
