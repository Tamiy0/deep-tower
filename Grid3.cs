using Godot;
using System;

public partial class Grid3 : TileMapLayer
{
		public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(40,104);

		CharacterBody2D Ours = this.GetNode<CharacterBody2D>("Ours");
		Ours.GlobalPosition = new Vector2(88,72);
	}
}
