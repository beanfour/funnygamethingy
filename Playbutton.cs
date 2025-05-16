using Godot;
using System;

public partial class Playbutton : Button
{
	public override void _Ready()
	{
		Pressed += OnPlayButtonPressed;
	}

	private void OnPlayButtonPressed()
	{
		GD.Print("Play button pressed!");
	}
}
