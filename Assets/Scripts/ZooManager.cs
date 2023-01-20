using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooManager : MonoBehaviour
{
    public GameObject Pen;
    public List<FriendlyAnimal> animals;
    // Start is called before the first frame update
    public List<GameObject> allPens = new List<GameObject>();
    void Start()
    {
        GameObject pen1 = Instantiate(Pen, transform.position, Quaternion.identity);
        allPens.Add(pen1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
