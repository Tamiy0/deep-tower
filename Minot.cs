using Godot;
using System;
using System.Threading;

public partial class Minot : CharacterBody2D
{
	public static float tilesize = 16;
	public Tween Tween;
	public Vector2 RIGHT = new Vector2(1,0);
	public Vector2 LEFT = new Vector2(-1,0);
	public Vector2 DOWN = new Vector2(0,1);
	public Vector2 UP = new Vector2(0,-1);
	public Vector2 ZERO = new Vector2(0,0);
	public bool IsMoving = false;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		IsMoving = false;

		// Recupération des noeuds enfants Raycast
		RayCast2D RayUp = this.GetNode<RayCast2D>("Up");
		RayCast2D RayDown = this.GetNode<RayCast2D>("Down");
		RayCast2D RayRight = this.GetNode<RayCast2D>("Right");
		RayCast2D RayLeft = this.GetNode<RayCast2D>("Left");

		// Gestion des inputs
		if((Tween == null) || (!Tween.IsRunning())) //Gestion de l'animation
		{
			if (Input.IsActionJustPressed("move_right") && (!RayRight.IsColliding()))
			{
				Move(RIGHT);
			}
			else if (Input.IsActionJustPressed("move_left") && (!RayLeft.IsColliding()))
			{
				Move(LEFT);
			}		
			else if (Input.IsActionJustPressed("move_down") && (!RayDown.IsColliding()))
			{
				Move(DOWN);
			}
			else if (Input.IsActionJustPressed("move_up") && (!RayUp.IsColliding()))
			{
				Move(UP);
			}
			else if (Input.IsActionJustPressed("not_moving"))
			{
				Move(ZERO);
			}
			else if (Input.IsActionJustPressed("restart"))
			{
				GetTree().ReloadCurrentScene();
			}
		}
	}

	public void Move(Vector2 dir)
	{
		TileMapLayer Grid = this.GetNode<TileMapLayer>("..");
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

		IsMoving = true;

		Vector2 targetPos = Grid.MapToLocal(targetTile);
		Tween = CreateTween();
		Tween.TweenProperty(this, "global_position", targetPos, 0.15f);
		Tween.TweenCallback(Callable.From(() => IsMoving = false));
	}
}
