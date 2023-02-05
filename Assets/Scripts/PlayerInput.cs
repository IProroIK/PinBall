using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Pin _leftPin;
    [SerializeField] private Pin _rightPin;
    private float _screenWidth;

    private void Awake()
    {
        _screenWidth = Screen.width;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            CheckInputSide();
        }
    }

    private void CheckInputSide()
    {
        Vector2 fingerPosition = Input.mousePosition;

        if(_screenWidth / 2 < fingerPosition.x)
        {
            _rightPin.Beat();
        }
        else if(_screenWidth / 2 > fingerPosition.x)
        {
            _leftPin.Beat();
        }
    }
}
