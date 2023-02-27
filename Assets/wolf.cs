using System.Threading.Tasks.Dataflow;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : hostileAnimal
{
    private  started Random_Start; // The starting position of the object
    public movekey movekey;

    // Start is called before the first frame update
    void Start()
    {
    Random_Start = TransformBlock.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
