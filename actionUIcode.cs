using Godot;
using System;

public partial class actionUIcode : Node
{
	var button = new Button();
		button.Text = "PRESS MEEE!!!";
		button.Pressed += ButtonPressed;
		button.Size = new Vector2(150, 150); 
		AddChild(button);
	}
	private void ButtonPressed()
	{
		GD.Print("Hello world!");
	}
