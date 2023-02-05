using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShadow : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    [SerializeField] private Transform _ball;
    [SerializeField] private Win _win;
    private void OnEnable()
    {
        _win.OnWin += DestroyShadow;
    }
    private void OnDisable()
    {
        _win.OnWin -= DestroyShadow;
    }

    private void LateUpdate()
    {
        BallFollow();
    }

    private void BallFollow()
    {
        transform.position = _ball.position - _offset;
    }

    private void DestroyShadow()
    {
        Destroy(gameObject);
    }
    
}
