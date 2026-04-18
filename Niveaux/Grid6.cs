using Godot;
using System;

public partial class Grid6 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(72,72);

		CharacterBody2D boule = this.GetNode<CharacterBody2D>("boule");
		boule.GlobalPosition = new Vector2(392,264);

		CharacterBody2D MonstreTest1 = this.GetNode<CharacterBody2D>("MonstreTest1");
		MonstreTest1.GlobalPosition = new Vector2(328,168);

		CharacterBody2D MonstreTest2 = this.GetNode<CharacterBody2D>("MonstreTest2");
		MonstreTest2.GlobalPosition = new Vector2(104,168);
	}
}
