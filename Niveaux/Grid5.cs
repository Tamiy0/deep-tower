using Godot;
using System;

public partial class Grid5 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(328,248);

		CharacterBody2D Ours1 = this.GetNode<CharacterBody2D>("Ours1");
		Ours1.GlobalPosition = new Vector2(296,232);

		CharacterBody2D Ours2 = this.GetNode<CharacterBody2D>("Ours2");
		Ours2.GlobalPosition = new Vector2(296,200);

		CharacterBody2D Ours3 = this.GetNode<CharacterBody2D>("Ours3");
		Ours3.GlobalPosition = new Vector2(296,216);

		CharacterBody2D Ours4 = this.GetNode<CharacterBody2D>("Ours4");
		Ours4.GlobalPosition = new Vector2(232,264);

		CharacterBody2D MonstreTest1 = this.GetNode<CharacterBody2D>("MonstreTest1");
		MonstreTest1.GlobalPosition = new Vector2(312,184);

		CharacterBody2D MonstreTest2 = this.GetNode<CharacterBody2D>("MonstreTest2");
		MonstreTest2.GlobalPosition = new Vector2(216,72);

		CharacterBody2D MonstreTest3 = this.GetNode<CharacterBody2D>("MonstreTest3");
		MonstreTest3.GlobalPosition = new Vector2(248,152);

		CharacterBody2D MonstreTest4 = this.GetNode<CharacterBody2D>("MonstreTest4");
		MonstreTest4.GlobalPosition = new Vector2(264,136);

		CharacterBody2D MonstreTest5 = this.GetNode<CharacterBody2D>("MonstreTest5");
		MonstreTest5.GlobalPosition = new Vector2(200,120);

		CharacterBody2D MonstreTest6 = this.GetNode<CharacterBody2D>("MonstreTest6");
		MonstreTest6.GlobalPosition = new Vector2(216,104);

		CharacterBody2D MonstreTest7 = this.GetNode<CharacterBody2D>("MonstreTest7");
		MonstreTest7.GlobalPosition = new Vector2(152,264);

		CharacterBody2D MonstreTest8 = this.GetNode<CharacterBody2D>("MonstreTest8");
		MonstreTest8.GlobalPosition = new Vector2(232,184);

		CharacterBody2D MonstreTest9 = this.GetNode<CharacterBody2D>("MonstreTest9");
		MonstreTest9.GlobalPosition = new Vector2(248,200);

		CharacterBody2D MonstreTest10 = this.GetNode<CharacterBody2D>("MonstreTest10");
		MonstreTest10.GlobalPosition = new Vector2(232,216);

		CharacterBody2D MonstreTest11 = this.GetNode<CharacterBody2D>("MonstreTest11");
		MonstreTest11.GlobalPosition = new Vector2(200,232);

		CharacterBody2D MonstreTest12 = this.GetNode<CharacterBody2D>("MonstreTest12");
		MonstreTest12.GlobalPosition = new Vector2(232,88);

	}

}
