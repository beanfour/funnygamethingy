using Godot;
using System;

public partial class FleeButton : Button
{
	public override void _Ready()
	{
		Pressed += OnPressed;
	}

	private void OnPressed()
	{
		Random rand = new Random();
		int randomInt = rand.Next(0, 11);
		if (randomInt < 5)
		{
			GD.Print("You Fled!");
			GD.Print("Returning to World Scene");
			GetTree().ChangeSceneToFile("res://scenes/world.tscn");
		}
		else
		{
			GD.Print("You Failed to Flee!");
			GD.Print("Slime Attacks!");
			var playerHealth = GetNode<PlayerHealth>("../PlayerHealth/PlayerHealth");
			GD.Print(playerHealth);
			if (playerHealth != null)
				playerHealth.TakeDamage(50);
			else
				GD.Print("PlayerHealth node not found!");
		}
	}
}