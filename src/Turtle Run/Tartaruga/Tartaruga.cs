using Godot;
using System;

public partial class Tartaruga : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	

	
	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		

		Vector2 direction = Input.GetVector("esquerda", "direita", "cima", "baixo");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			velocity.Y = direction.Y * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
		   var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");

	if (velocity.Length() > 0)
	{
		velocity = velocity.Normalized() * Speed;
		animatedSprite2D.Play();
	}
	else
	{
		animatedSprite2D.Stop();
	}
	}
	private void _on_area_2d_body_entered(Node2D body)
{
	GetTree().ChangeSceneToFile("res://Tela Game Over/GameOver.tscn");
}
}



