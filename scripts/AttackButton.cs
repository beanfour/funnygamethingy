using Godot;
using System;

public partial class AttackButton : Button
{
	public override void _Ready()
	{
		Pressed += OnPressed;
	}

	private void OnPressed()
	{
		Random rand = new Random();
		int randomInt = rand.Next(0, 11);
		if (randomInt < 3)
		{
			GD.Print("You Missed!");
			GD.Print("Slime Attacks!");
			//copilot helped me call the PlayerHealth node and take damage
			// if (playerHealth != null) for making sure the script is referencing the correct node in debugging
			var playerHealth = GetNode<PlayerHealth>("../PlayerHealth/PlayerHealth");
			GD.Print(playerHealth);
			if (playerHealth != null)
				playerHealth.TakeDamage(25);
			else
				GD.Print("PlayerHealth node not found!");
		}
		else
		{//replicated the code from the previous attack button
			GD.Print("You Hit!");
			GD.Print("Slime Takes Damage!");
			var enemyHealth = GetNode<EnemyHealth>("../../EnemyPanel/EnemyHealth/EnemyHealth");
						GD.Print(enemyHealth);
			if (enemyHealth != null)
				enemyHealth.TakeDamage(25);
			else
				GD.Print("enemyHealth node not found!");
		}
	}
}
