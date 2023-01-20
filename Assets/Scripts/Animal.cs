using UnityEngine;

public abstract class Animal : MonoBehaviour{
	public Transform animalTransformer;
	
	public void playAnimalSound(string sound){
		print(sound);
	}
} 