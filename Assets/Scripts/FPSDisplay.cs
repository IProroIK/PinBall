using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FPSDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _fpsText;
    private float _pollingTime = 1f;
    private int _frameCount;
    private float _time;
    private void Update()
    {
        DisplayFps();
    }

    private void DisplayFps()
    {
        _time += Time.deltaTime;
        _frameCount++;

        if(_time >= _pollingTime)
        {
            int frameRate = Mathf.RoundToInt(_frameCount / _time);
            _fpsText.text = frameRate.ToString() + " FPS";
            _time -= _pollingTime;
            _frameCount = 0;
        }
    }

}
