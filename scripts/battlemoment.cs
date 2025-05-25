using Godot;
using System;

public partial class battlemoment : CharacterBody2D
{
	private AnimatedSprite2D _anim;

	public override void _Ready()
	{
		_anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_anim.Play("back_idle");
		_anim.FlipH = false;
	}
}
