using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson_6.Animals
{
    public abstract class FriendlyAnimal : Animal, IFriendlyAnimal
    {
        public AnimalPen Pen;
        public void Die(){
            Pen.Animals.Remove(this);
            Destroy(gameObject);
            
        }
void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Pig")
            {
                //destroy the object
                Destroy(col.gameObject);
            }
            if (col.gameObject.tag == "Cat")
            {
                //destroy the object
                Destroy(col.gameObject);
            }
            if (col.gameObject.tag == "Sheep")
            {
                //destroy the object
                Destroy(col.gameObject);
            }
        }
// If wolf hits the cat, the cat will die


        public void OnMouseDown()
        {

            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}