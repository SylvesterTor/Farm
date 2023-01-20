using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooManager : MonoBehaviour
{
    public GameObject Pen;
    public GameObject animal;
    // Start is called before the first frame update
    public List<Pen> allPens = new List<Pen>();
    public List<Animal> allAnimals =new List<Animal>();
    void Start()
    {
        Pen pen = createPen(Pen, animal);
        allPens.Add(pen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Pen createPen(GameObject penToSpawn, GameObject animalToSpawn){
        GameObject penSpawn = Instantiate(penToSpawn, transform.position, Quaternion.identity);
        Pen PenSpawnScript = penSpawn.GetComponent<Pen>(); 
        PenSpawnScript.spawnAnimal(animalToSpawn);
        PenSpawnScript.spawnAnimal(animalToSpawn);
        PenSpawnScript.spawnAnimal(animalToSpawn);
        PenSpawnScript.spawnAnimal(animalToSpawn);
        return penToSpawn.GetComponent<Pen>();
    }
}
