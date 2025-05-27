using Godot;
using System;

public partial class AttackButton : Button
{
    public override void _Ready()
    {
        Pressed += OnButtonPressed;
    }

    private void OnButtonPressed()
    {
        GD.Print("Attack button pressed");
    }
}