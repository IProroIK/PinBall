using TMPro;
using UnityEngine;

public class WinUI : MonoBehaviour
{
    [SerializeField] private Win _win;
    [SerializeField] private GameObject _winUI;
    [SerializeField] private TextMeshProUGUI _winUIText;
    private void OnEnable()
    {
        _win.OnWin += ActiveWinUI;
    }

    private void OnDisable()
    {
        _win.OnWin -= ActiveWinUI;
    }

    private void ActiveWinUI()
    {
        _winUI.SetActive(true);
    }

}
