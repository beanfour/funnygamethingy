using Godot;
using System;

public partial class Slime : CharacterBody2D
{
	private int Health = 100;
	private int Damage = 10;
	private AnimatedSprite2D _anim;

	public override void _Ready()
	{
		_anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_anim.Play("idle");
	}
}
