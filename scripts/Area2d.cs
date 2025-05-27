using Godot;
using System;

public partial class Area2d : Area2D
{
    // Copilot helped me write collision detection code
    public override void _Ready()
    {
        BodyEntered += OnBodyEntered;
    }

    private void OnBodyEntered(Node body)
    {
        if (body.Name == "Player")
        {
            GetTree().ChangeSceneToFile("res://scenes/battle_scene.tscn");
        }
    }
}
