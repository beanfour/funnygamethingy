using Godot;
using System;

public partial class EnemyHealth : ProgressBar
{
    public override void _Ready()
    {
        Value = MaxValue;
    }

    public void TakeDamage(int amount)
    {
        Value -= amount;
        if (Value <= MinValue)
        {
            GD.Print("Enemy defeated!");
            GetTree().ChangeSceneToFile("scenes/world.tscn");
        }
    }
}
