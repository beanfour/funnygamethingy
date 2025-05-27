using Godot;
using System;

public partial class AttackButton : Button
{
    [Export]
    public NodePath PlayerNodePath;

    private AnimatedSprite2D _playerAnim;

    public override void _Ready()
    {
        Pressed += OnButtonPressed;

        if (!PlayerNodePath.IsEmpty)
        {
            var playerNode = GetNodeOrNull<Node2D>(PlayerNodePath);
            if (playerNode != null)
                _playerAnim = playerNode.GetNodeOrNull<AnimatedSprite2D>("AnimatedSprite2D");
            else
                GD.PrintErr("Player node not found at path: ", PlayerNodePath);
        }
        else
        {
            GD.PrintErr("PlayerNodePath is empty!");
        }
    }

    private void OnButtonPressed()
    {
        if (_playerAnim != null)
            _playerAnim.Play("basic_attack_back");
        else
            GD.PrintErr("Player AnimatedSprite2D not found!");
    }
}