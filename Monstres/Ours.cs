using Godot;
using System;

public partial class Ours : MonstreDeBase
{
	public static float tilesize = 16;
	public Vector2 RIGHT = new Vector2(1,0);
	
	public bool Seen = false;

	public override void _Process(double delta)
	{
		RayCast2D Vision = this.GetNode<RayCast2D>("Vision");
		var collider = Vision.GetCollider();
		if (collider is Minot)
			Seen = true;
		if (Seen)
			Move(RIGHT);
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
				return;
			
			var tousLesMonstres = GetTree().GetNodesInGroup("Monstres");
			foreach (MonstreDeBase autreMonstre in tousLesMonstres)
			{
				if (autreMonstre != this) 
				{
					Vector2I caseAutreMonstre = Grid.LocalToMap(autreMonstre.GlobalPosition);
					if (caseAutreMonstre == targetTile || autreMonstre.CaseCible == targetTile)
						return;
				}
			}
			this.CaseCible = targetTile;

		Vector2 targetPos = Grid.MapToLocal(targetTile);
		Tween tween = CreateTween();
		tween.TweenProperty(this, "global_position", targetPos, 0.18f);
		}

	}
}
