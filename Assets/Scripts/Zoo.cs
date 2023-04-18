using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using Lesson_6;
using Lesson_6.Animals;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    public List<GameObject> AnimalPrefabs;
    public GameObject AnimalPenPrefab;

    public List<AnimalPen> Pens;
    public List<Animal> AllAnimals;

    protected void Start()
    {
        Pens = new List<AnimalPen>();
        AllAnimals = new List<Animal>();

        for (int i = 0; i < 1; i++)
        {
            AnimalPen pen = Spawner(i);
            AllAnimals.AddRange(pen.Animals);
            Pens.Add(pen);
        }
    }

    private AnimalPen Spawner(int counter)
    {
        //Spawn animal pen
        GameObject go = Instantiate(AnimalPenPrefab, transform);
        //Set the position of the pen to be 50 units away from the previous pen in both x and z
        Vector3 spawnLocation = new Vector3((counter + 1) * 50, 0, (counter + 1) * 50);
        go.transform.SetPositionAndRotation(spawnLocation, Quaternion.identity);
        AnimalPen pen = go.GetComponent<AnimalPen>();

        //Spawn animals in the pen using different methods
        switch (counter)
        {
            case 0:
              List<GameObject> wolfs = new List<GameObject>();
                
                    wolfs.Add(AnimalPrefabs[2]);
                
                List<GameObject> Friendanimal = new List<GameObject>();
                for (int i = 0; i < 5; i++)
                {
                    Friendanimal.Add(AnimalPrefabs[1]);
                    Friendanimal.Add(AnimalPrefabs[0]);
                    pen.SpawnAnimals(Friendanimal);
                }
                pen.SpawnHostile(wolfs);
                break;
            default:
                break;
        }
        return pen;
    }
}
