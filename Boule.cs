using Godot;
using System;

public partial class Boule : MonstreDeBase
{
	public static float tilesize = 16;
	public Vector2 RIGHT = new Vector2(1,0);
	public Vector2 LEFT = new Vector2(-1,0);
	public Vector2 DOWN = new Vector2(0,1);
	public Vector2 UP = new Vector2(0,-1);
	public Vector2 ZERO = new Vector2(0,0);
	


	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("move_right"))
			{
				Move(LEFT);
			}
			else if (Input.IsActionJustPressed("move_left"))
			{
				Move(RIGHT);
			}		
			else if (Input.IsActionJustPressed("move_down"))
			{
				Move(UP);
			}
			else if (Input.IsActionJustPressed("move_up"))
			{
				Move(DOWN);
			}
			else if (Input.IsActionJustPressed("not_moving"))
			{
				Move(ZERO);
			}
	}

	public void Move(Vector2 dir)
	{
		TileMapLayer Grid = this.GetNode<TileMapLayer>("..");
		Minot Minot = this.GetNode<Minot>("../Minot");

		if(!Minot.IsMoving)
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
				return;

			var tousLesMonstres = GetTree().GetNodesInGroup("Monstres");
			foreach (MonstreDeBase autreMonstre in tousLesMonstres)
			{
				if (autreMonstre != this) 
				{
					Vector2I caseAutreMonstre = Grid.LocalToMap(autreMonstre.GlobalPosition);
					if (caseAutreMonstre == targetTile)
						return;
				}
			}

		Vector2 targetPos = Grid.MapToLocal(targetTile);
		Tween tween = CreateTween();
		tween.TweenProperty(this, "global_position", targetPos, 0.18f);
		}

	}
}
