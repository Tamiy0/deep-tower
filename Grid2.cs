using Godot;
using System;

public partial class Grid2 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(40,24);
	}

}
