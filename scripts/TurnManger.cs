using Godot;
using System;

public partial class TurnManger : Node
{
    private bool _playerTurn = true;

    public void NextTurn()
    {
        _playerTurn = !_playerTurn;
    }

    public bool IsPlayerTurn()
    {
        return _playerTurn;
    }
}
