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

        // Get the player's AnimatedSprite2D node using the exported path
        if (PlayerNodePath != null && !PlayerNodePath.IsEmpty)
        {
            var playerNode = GetNodeOrNull<Node2D>(PlayerNodePath);
            if (playerNode != null)
                _playerAnim = playerNode.GetNodeOrNull<AnimatedSprite2D>("AnimatedSprite2D");
        }
    }

    private void OnButtonPressed()
    {
        GD.Print("Attack button pressed");
        if (_playerAnim != null)
            _playerAnim.Play("attack");
    }
}