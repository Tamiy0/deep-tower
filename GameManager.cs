using Godot;
using System;

public partial class GameManager : Node
{
	public void EnregistrerMonstre(MonstreDeBase monstre)
	{
		monstre.JoueurAttrape += GameOver;
		GD.Print($"Monstre {monstre.Name} enregistré par le GameManager");
	}

	private void GameOver()
	{
		GD.Print("Le joueur a été attrapé ! Condition de défaite activée.");
		GetTree().CallDeferred(SceneTree.MethodName.ChangeSceneToFile, "res://UI//ecran_defaite.tscn");
	}
}
