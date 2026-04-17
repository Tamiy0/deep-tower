using Godot;
using System;

public partial class Grid3 : TileMapLayer
{
		public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(232,248);

		CharacterBody2D MonstreTest1 = this.GetNode<CharacterBody2D>("MonstreTest1");
		MonstreTest1.GlobalPosition = new Vector2(216,216);

		CharacterBody2D MonstreTest2 = this.GetNode<CharacterBody2D>("MonstreTest2");
		MonstreTest2.GlobalPosition = new Vector2(360,200);

		CharacterBody2D MonstreTest3 = this.GetNode<CharacterBody2D>("MonstreTest3");
		MonstreTest3.GlobalPosition = new Vector2(72,264);

		CharacterBody2D MonstreTest4 = this.GetNode<CharacterBody2D>("MonstreTest4");
		MonstreTest4.GlobalPosition = new Vector2(152,136);

		CharacterBody2D MonstreTest5 = this.GetNode<CharacterBody2D>("MonstreTest5");
		MonstreTest5.GlobalPosition = new Vector2(72,120);

		CharacterBody2D MonstreTest6 = this.GetNode<CharacterBody2D>("MonstreTest6");
		MonstreTest6.GlobalPosition = new Vector2(168,104);
	}
}
