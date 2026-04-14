using Godot;
using System;

public partial class MonstreTest : MonstreDeBase
{
	public static float tilesize = 16;
	public Vector2 RIGHT = new Vector2(1,0);
	public Vector2 LEFT = new Vector2(-1,0);
	public Vector2 DOWN = new Vector2(0,1);
	public Vector2 UP = new Vector2(0,-1);
	public bool right = true;

	public override void _Process(double delta)
	{

		// Recupération des noeuds enfants Raycast
		RayCast2D RayUp = this.GetNode<RayCast2D>("Up");
		RayCast2D RayDown = this.GetNode<RayCast2D>("Down");
		RayCast2D RayRight = this.GetNode<RayCast2D>("Right");
		RayCast2D RayLeft = this.GetNode<RayCast2D>("Left");

		// Pour le test mouvemnt de gauche à droite à l'horizontale
		if(right)
		{
			Move(RIGHT);
		}
		else
		{
			Move(LEFT);
		}

	}

	public void Move(Vector2 dir)
	{
		TileMapLayer Grid = this.GetNode<TileMapLayer>("..");
		Minot Minot = this.GetNode<Minot>("../Minot");

		if(Minot.IsMoving)
		{
			if (Grid == null) 
			{
				GD.PrintErr("Erreur : TileMapLayer non trouvé !");
				return;
			}

			Vector2I currentTile = Grid.LocalToMap(GlobalPosition);
			Vector2I targetTile = currentTile + (Vector2I)dir;  

			TileData tile_data = Grid.GetCellTileData(targetTile);
			if (tile_data == null || !tile_data.GetCustomData("walkable").AsBool())
			{
				right = !right;
				return;
			}

		Vector2 targetPos = Grid.MapToLocal(targetTile);
		Tween tween = CreateTween();
		tween.TweenProperty(this, "global_position", targetPos, 0.18f);
		}

	}

	//Gestion des collisions
}
