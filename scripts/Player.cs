using Godot;
using System;

public partial class Player : CharacterBody2D
{
	// Movement speed in pixels per second
	[Export]
	public int Speed = 100;

	public override void movement(double delta)
	{
		Vector2 velocity = Vector2.Zero;

		if (Input.IsActionPressed("ui_right"))
			velocity.X += 1;
		if (Input.IsActionPressed("ui_left"))
			velocity.X -= 1;
		if (Input.IsActionPressed("ui_down"))
			velocity.Y += 1;
		if (Input.IsActionPressed("ui_up"))
			velocity.Y -= 1;

		velocity = velocity.Normalized() * Speed;
		Velocity = velocity;
		MoveAndSlide();
	}
}
