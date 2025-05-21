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
            velocity.Y += 1;
        if (Input.IsActionPressed("ui_up"))
            velocity.Y -= 1;

        // Normalize for diagonal movement
        velocity = velocity.Normalized() * Speed;
        Velocity = velocity;
        MoveAndSlide();

        // Play animation based on movement direction
        if (velocity.Length() > 0)
        {
            if (Mathf.Abs(velocity.X) > Mathf.Abs(velocity.Y))
            {
                _anim.Play("side_walk");
                _anim.FlipH = velocity.X < 0;
            }
            else if (velocity.Y < 0)
            {
                _anim.Play("front_walk");
                _anim.FlipH = false;
            }
            else if (velocity.Y > 0)
            {
                _anim.Play("backwards_walk");
                _anim.FlipH = false;
            }
        }
        else
        {
            _anim.Play("idle");
            _anim.FlipH = false;
        }
    }
}
