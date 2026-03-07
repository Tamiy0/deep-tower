using Godot;
using System;

public partial class NextLevel : Sprite2D
{
	[Export]
	PackedScene nextLevel;
	private void OnPassageBodyEntered(Node2D body)
	{
		GD.Print("Body détecté !!");
		GetTree().ChangeSceneToPacked(nextLevel);
	}
}
