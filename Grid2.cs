using Godot;
using System;

public partial class Grid2 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(40,24);

		CharacterBody2D MonstreTest = this.GetNode<CharacterBody2D>("MonstreTest");
		MonstreTest.GlobalPosition = new Vector2(24,72);
	}

}
