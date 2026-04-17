using Godot;
using System;

public partial class Grid4 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(40,24);

		CharacterBody2D Boule = this.GetNode<CharacterBody2D>("boule");
		Boule.GlobalPosition = new Vector2(88,24);
	}

}
