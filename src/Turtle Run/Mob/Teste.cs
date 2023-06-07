using Godot;
using System;

public partial class Teste : CharacterBody2D
{
	public const float Speed = 200.0f;
	public const float JumpVelocity = -200.0f;

	
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
			velocity.Y = JumpVelocity;

		
		

		Velocity = velocity;
		MoveAndSlide();
	}
	
 	/*private void _on_area_2d_body_entered(Node2D body)
{
	
	QueueFree();
	
}*/
}



