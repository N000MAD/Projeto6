using Godot;
using System;

public partial class GameOver : Node2D
{



	public override void _Ready()
	{
	}


	public override void _Process(double delta)
	{
	}
	
	private void _on_button_pressed()
{
	GetTree().ChangeSceneToFile("res://Tela de início/TelaInicio.tscn");
}

}



