using Godot;
using System;

public partial class Grid2 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(232,168);

		MonstreTest MonstreTest1 = this.GetNode<MonstreTest>("MonstreTest1");
		MonstreTest1.GlobalPosition = new Vector2(232,72);

		MonstreTest MonstreTest2 = this.GetNode<MonstreTest>("MonstreTest2");
		MonstreTest2.GlobalPosition = new Vector2(232,104);
		MonstreTest2.right = false;

		MonstreTest MonstreTest3 = this.GetNode<MonstreTest>("MonstreTest3");
		MonstreTest3.GlobalPosition = new Vector2(232,200);
	}

}
