using Godot;
using System;

public partial class Grid1 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(216,104);
	}

}
