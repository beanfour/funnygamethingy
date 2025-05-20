using Godot;
using System;

public partial class actionUIcode : Node
{
  
    public override void _Ready()
    {
        var button = new Button();
        button.Text = "Fight";
        button.Pressed += ButtonPressed;
        button.Size = new Vector2(150, 200); // Set button size to 150x200
        AddChild(button);
    }

    private void ButtonPressed()
    {
        GD.Print("Hello world!");
    }
}

