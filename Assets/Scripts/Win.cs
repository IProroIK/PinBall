using System;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public event Action OnWin;

    [SerializeField] private List<Tile> _tiles;
    [SerializeField] private int _activeTilesCounter;
    [SerializeField] private int _allLevelTiles;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Transform _ball;
    [SerializeField] private ParticleSystem _winParticle;
    [Range(0.0f, 1.0f)]
    [SerializeField] private float _coefficientOfActiveTileToWin;


    private void Awake()
    {
        _allLevelTiles = _tiles.Count;
    }

    public void CheckWinCondition()
    {
        if(_allLevelTiles * _coefficientOfActiveTileToWin <= _activeTilesCounter)
        {
            OnWin?.Invoke();
            _playerInput.enabled = false;
            Destroy(_ball.gameObject);
            _winParticle.gameObject.SetActive(true);
        }
    }

    public void AddActiveTileCount()
    {
        _activeTilesCounter++;
    }
}
