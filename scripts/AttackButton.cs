using Godot;
using System;

public partial class AttackButtonHandler : Node
{
	public override void _Ready()
	{
		
		GetNode<Button>("AttackButton").Pressed += OnPressed;
	}

	private void OnPressed()
	{
		GD.Print("Attack button pressed!");

		
		var player = GetNode<Node2D>("/root/battleScene/player");
		var animPlayer = player.GetNode<AnimationPlayer>("AnimationPlayer");

		animPlayer.Play("basic_attack_back");
	}
}
