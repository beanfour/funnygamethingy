using Godot;
using System;

public partial class PlayerHealth : ProgressBar
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
            GetTree().ChangeSceneToFile("scenes/DeathScreen.tscn");
        }
    }
}

