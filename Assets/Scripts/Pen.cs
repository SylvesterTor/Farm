using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public List<Animal> animalsInPen = new List<Animal>();

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnAnimal(GameObject animal){
        Instantiate(animal, transform.position, Quaternion.identity);
    }
}
