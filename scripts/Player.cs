using Godot;
using System;

public partial class Player : CharacterBody2D
{
	[Export]
	public int Speed = 200;

	private AnimatedSprite2D _anim;

	public override void _Ready()
	{
		_anim = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Vector2.Zero;

		if (Input.IsActionPressed("ui_right"))
			velocity.X += 1;
		if (Input.IsActionPressed("ui_left"))
			velocity.X -= 1;
		if (Input.IsActionPressed("ui_down"))
			velocity.Y += 1;d))
			velocity.Y -= 1;

		// Normalize for diagonal movement
		velocity = velocity.Normalized() * Speed;
		Velocity = velocity;
		MoveAndSlide();

		// Play animation based on movement
		if (velocity.Length() > 0)
		{
			_anim.Play("idle");
		}
		else
		{
			_anim.Play("walk_side");
		}

		// Flip sprite based on direction (optional)
		if (velocity.X != 0)
		{
			_anim.FlipH = velocity.X < 0;
		}
	}
}
