using UnityEngine;

public abstract class HostileAnimal : Animal, HostileAnimalInterface
{
	public void attack(FriendlyAnimal opponent)
	{
		Vector2.MoveTowards(transform.position,opponent.transform.position,0.5f);
		Destroy(opponent);
		Debug.Log(opponent.name + " died");
	}
	public void attack(HostileAnimal opponent)
	{
		Vector2.MoveTowards(transform.position,opponent.transform.position,0.5f);
		if (Random.Range(1,4) > 1) Destroy(opponent);
		else Destroy(gameObject);
		Debug.Log(opponent.name + " died");
	}

	public bool Scare()
	{
		if (Random.Range(1,3) == 1) return true;
		else return false;
	}
}