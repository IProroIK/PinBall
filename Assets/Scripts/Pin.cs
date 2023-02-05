using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Pin : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidBody;
    [SerializeField] private float _pinPower;

    public void Beat()
    {
        _rigidBody.AddTorque(_pinPower);
    }

}
