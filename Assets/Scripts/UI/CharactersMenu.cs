using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersMenu : MonoBehaviour
{
    [SerializeField] private GameObject _imagePrefab;
    [SerializeField] private Transform _content;
    [SerializeField] private GameObject _selectMark;
    [SerializeField] private MenuInputHandler _inputHandler;
    [SerializeField] private FightCreator _fightCreator;

    private List<CharacterInfo> _models = new List<CharacterInfo>();
    private List<GameObject> _images = new List<GameObject>();
    private int _currentPos = 0;

    private void OnEnable()
    {
        _inputHandler.OnMoveClick += MoveClick;
        _inputHandler.OnEnterClick += EnterClick;
        _fightCreator.OnPlayerSelected += OnCharacterSelected;
    }

    private void OnCharacterSelected(int index)
    {
        _images[index].GetComponent<Image>().color= Color.red;
    }

    private void EnterClick()
    {
        _fightCreator.CheckSelection(_currentPos);
    }

    private void MoveClick(int pos)
    {
        _currentPos += pos;
        if (_currentPos == _images.Count)
            _currentPos = 0;
        if (_currentPos == -1)
            _currentPos = _images.Count - 1;
        if (_currentPos < 0 || _currentPos > _images.Count)
        {
            _currentPos -= pos;
            return;
        }
        _selectMark.transform.position = _images[_currentPos].transform.position - new Vector3(0, 1.2f, 0);
    }

    private void Start()
    {
        _models.AddRange(GameObject.FindObjectsOfType<CharacterInfo>());
        _models.Sort((x, y) => x.Number.CompareTo(y.Number));
        InitializeContent();
    }

    private void InitializeContent()
    {
        foreach (var model in _models)
        {
            var image = Instantiate(_imagePrefab, _content);
            image.GetComponent<Image>().sprite = model.Sprite;
            _images.Add(image);
        }
        _selectMark.transform.position = _images[0].transform.position - new Vector3(0, 1.2f, 0);
    }
}
