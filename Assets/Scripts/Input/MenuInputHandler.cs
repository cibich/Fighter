using System;
using UnityEngine;

public class MenuInputHandler : MonoBehaviour
{
    public Action<int> OnMoveClick;
    public Action OnEnterClick;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            OnMoveClick?.Invoke(-1);
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            OnMoveClick?.Invoke(1);
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            OnMoveClick?.Invoke(-3);
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            OnMoveClick?.Invoke(3);
        if(Input.GetKeyDown(KeyCode.Return))
            OnEnterClick?.Invoke();
    }
}
