using UnityEngine;

public abstract class HostileAnimal : Animal, HostileAnimalInterface
{
	public void Fight(Animal opponent)
	{
		Vector2.MoveTowards(transform.position,opponent.transform.position,2f);
	}
	public bool Scare()
	{
		return true;
	}
}