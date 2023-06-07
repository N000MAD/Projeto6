using Godot;
using System;

public partial class TelaCredit : Node2D
{
	
	public override void _Ready()
	{
	}

	
	public override void _Process(double delta)
	{
		
		
	}
	private void _on_bt_voltar_pressed()
{
	GetTree().ChangeSceneToFile("res://Tela de início/TelaInicio.tscn");
}
	
}





