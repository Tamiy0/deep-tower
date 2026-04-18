using Godot;
using System;

public partial class MonstreDeBase : CharacterBody2D
{
	[Signal]
	public delegate void JoueurAttrapeEventHandler();

	public Vector2I CaseCible = new Vector2I(-999, -999);

	public override void _Ready()
	{
		var gameManager = GetNode<GameManager>("/root/GameManager");
		gameManager.EnregistrerMonstre(this);
		Area2D hitbox = GetNodeOrNull<Area2D>("Hitbox");
		if (hitbox != null)
		{
			hitbox.BodyEntered += OnBodyEntered;
		}
		else
		{
			GD.PrintErr($"Attention : Le monstre {Name} n'a pas de nœud Area2D nommé 'Hitbox' !");
		}
	}

	private void OnBodyEntered(Node2D body)
	{
		if (body.IsInGroup("Joueur")) 
		{
			EmitSignal(SignalName.JoueurAttrape);
		}
	}

}
