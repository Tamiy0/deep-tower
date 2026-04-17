using Godot;
using System;

public partial class Grid4 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(88,216);

		CharacterBody2D Ours1 = this.GetNode<CharacterBody2D>("Ours1");
		Ours1.GlobalPosition = new Vector2(72,184);

		CharacterBody2D Ours2 = this.GetNode<CharacterBody2D>("Ours2");
		Ours2.GlobalPosition = new Vector2(72,88);

		CharacterBody2D Ours3 = this.GetNode<CharacterBody2D>("Ours3");
		Ours3.GlobalPosition = new Vector2(72,152);

		CharacterBody2D Ours4 = this.GetNode<CharacterBody2D>("Ours4");
		Ours4.GlobalPosition = new Vector2(296,120);

	}

}
