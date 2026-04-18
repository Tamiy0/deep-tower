using Godot;
using System;

public partial class Grid7 : TileMapLayer
{
	public override void _Ready()
	{
		CharacterBody2D Minot = this.GetNode<CharacterBody2D>("Minot");
		Minot.GlobalPosition = new Vector2(72,264);

		CharacterBody2D boule = this.GetNode<CharacterBody2D>("boule");
		boule.GlobalPosition = new Vector2(392,72);

		CharacterBody2D Ours = this.GetNode<CharacterBody2D>("Ours");
		Ours.GlobalPosition = new Vector2(56,168);
	}
}
