using Godot;
using System;

public partial class RespawnButton : Button
{
    public override void _Ready()
    {
        Pressed += OnButtonPressed;
    }
    private void OnButtonPressed()
	{
        GetTree().ChangeSceneToFile("res://scenes/world.tscn");
	}
}
