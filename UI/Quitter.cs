using Godot;
using System;

public partial class Quitter : Sprite2D
{
	private async void OnPassageBodyEntered(Node2D body)
	{
		await ToSignal(GetTree().CreateTimer(0.5), SceneTreeTimer.SignalName.Timeout);
		GetTree().Quit();
	}
}
