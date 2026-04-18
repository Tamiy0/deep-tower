using Godot;
using System;

public partial class RetourMenu : Sprite2D
{
	private async void OnPassageBodyEntered(Node2D body)
	{
		GetTree().CallDeferred(SceneTree.MethodName.ChangeSceneToFile, "res://UI//menu.tscn");
	}
}
