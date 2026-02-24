using Godot;
using System;
using System.Threading;

public partial class Minot : CharacterBody2D
{
	public static float tilesize = 16;
	public Tween sprite_node_pos_tween;
	public Vector2 RIGHT = new Vector2(1,0);
	public Vector2 LEFT = new Vector2(-1,0);
	public Vector2 DOWN = new Vector2(0,1);
	public Vector2 UP = new Vector2(0,-1);

	public override void _Ready()
	{
		this.GlobalPosition = new Vector2(56,56);	
		//Test ezavufbhozfe js,pfkidno
	}

	public override void _Process(double delta)
	{
		RayCast2D RayUp = this.GetNode<RayCast2D>("Up");
		RayCast2D RayDown = this.GetNode<RayCast2D>("Down");
		RayCast2D RayRight = this.GetNode<RayCast2D>("Right");
		RayCast2D RayLeft = this.GetNode<RayCast2D>("Left");
		if((sprite_node_pos_tween == null) || (!sprite_node_pos_tween.IsRunning())) //Gestion de l'animation (pour plus tard pas que le joueur puisse entrer un input)
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
		}


		TileMapLayer Grid = this.GetNode<TileMapLayer>("../Grid");
	}

	public void Move2(Vector2 dir)
	{
		Sprite2D spriteCharacter = this.GetNode<Sprite2D>("Sprite2D");
		this.GlobalPosition += dir*tilesize;
		spriteCharacter.GlobalPosition -= dir*tilesize;

		if(sprite_node_pos_tween != null)
			sprite_node_pos_tween.Kill();
		sprite_node_pos_tween = CreateTween();
		sprite_node_pos_tween.SetProcessMode(Tween.TweenProcessMode.Physics);
		sprite_node_pos_tween.TweenProperty(spriteCharacter,"position", GlobalPosition, 0.185f).SetTrans(Tween.TransitionType.Sine);
	}

	public void Move(Vector2 dir)
	{
		TileMapLayer Grid = this.GetNode<TileMapLayer>("../Grid");
		if (Grid == null) 
		{
			GD.PrintErr("Erreur : TileMapLayer non trouvé !");
			return;
		}

		Vector2I current_tile = Grid.LocalToMap(GlobalPosition);
		Vector2I target_tile = current_tile + (Vector2I)dir;  

		TileData tile_data = Grid.GetCellTileData(target_tile);
		if (tile_data == null || !tile_data.GetCustomData("walkable").AsBool())
			return;

		this.GlobalPosition = Grid.MapToLocal(target_tile);
	}
}
