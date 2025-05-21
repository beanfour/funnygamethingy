using Godot;
using System;

public partial class Coins : CharacterBody2D
{
    [Export]
    public float AttractSpeed = 300f;

    [Export]
    public float AttractRadius = 100f;

    private Node2D _player;

    public override void _Ready()
    {
        // Adjust the path if your player node is elsewhere
        _player = GetTree().Root.GetNode<Node2D>("Main/Player");
    }

    public override void _PhysicsProcess(double delta)
    {
        if (_player == null)
            return;

        Vector2 toPlayer = _player.GlobalPosition - GlobalPosition;
        if (toPlayer.Length() < AttractRadius)
        {
            Vector2 move = toPlayer.Normalized() * AttractSpeed * (float)delta;
            GlobalPosition += move;
        }
    }
}
