using Godot;
using System;

public partial class principal : Node2D
{
	public PackedScene MobScene=GD.Load<PackedScene>("res://Mob/Mob.tscn");
	public RichTextLabel relogio;
	public int pontuacao = 0;
	public override void _Process(double delta)
	{
	}
	private void _on_timer_mobs_timeout()
{
	pontuacao++;
	relogio = this.GetNode<RichTextLabel>("RichTextLabel");
	var random = new RandomNumberGenerator();
	random.Randomize();

	Node2D Lixo= MobScene.Instantiate<Node2D>();
	Lixo.Position = new Vector2(random.RandiRange(0,480),-168);
	AddChild(Lixo);

	relogio.Text = "[center] " + pontuacao;
	
	
}

}






