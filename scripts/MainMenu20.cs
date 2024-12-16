using Godot;
using System;

public partial class MainMenu20 : Node2D
{
	[Export] public Label myLabel;

	public override void _Ready() 
	{
		myLabel.Text = "Changed the label on Ready in C#";
	}

	public override void _Process(double delta)	{ }

	private int count = 0;
	public void _on_button_button_up()
	{
        myLabel.Text = "Clicked!! " + count;
		count++;
    }
}
