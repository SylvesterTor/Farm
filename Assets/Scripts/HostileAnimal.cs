using UnityEngine;

public abstract class HostileAnimal : Animal, HostileAnimalInterface
{
	public void Fight()
	{
		throw new System.NotImplementedException();
	}

	public bool Scare()
	{
		throw new System.NotImplementedException();
	}
}