using System;
using UnityEngine;

public class FightCreator : MonoBehaviour
{
    public Action<int> OnPlayerSelected;
    [SerializeField] private SceneLoader _sceneLoader;
    [SerializeField] private RoundsContainer _roundContainer;
    private bool _isPlayerOne = false;
    private bool _isPlayerTwo = false;
    private int _playerOne;
    private int _playerTwo;

    public void CheckSelection(int numberPlayer)
    {
        if (_isPlayerOne == false)
        {
            _playerOne = numberPlayer;
            _isPlayerOne = true;
            OnPlayerSelected?.Invoke(_playerOne);
        }
        if (numberPlayer == _playerOne || _isPlayerTwo == true)
            return;

        _playerTwo = numberPlayer;
        OnPlayerSelected?.Invoke(_playerTwo);
        _isPlayerTwo = true;
        _sceneLoader.LoadNextScene(_roundContainer.GetRoundNumb(_playerOne, _playerTwo));
    }
}
