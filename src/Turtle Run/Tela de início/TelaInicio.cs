using Godot;
using System;

public partial class TelaInicio : Node2D
{
	
	public override void _Ready()
	{
	}

	
	public override void _Process(double delta)
	{
				
		
	}
	
	private void _on_bt_start_pressed()
{
	GetTree().ChangeSceneToFile("res://Main/main.tscn");
}
		private void _on_bt_credi_pressed()
{
	GetTree().ChangeSceneToFile("res://Tela de créditos/TelaCredito.tscn");
}
}






