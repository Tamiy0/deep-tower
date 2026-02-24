using Godot;
using System;

public partial class NextLevel : Area2D
{
	void on_body_entered()
	{
		GetTree().ChangeSceneToFile("res://level1.tscn");
	}
}
