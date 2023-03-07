using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson_6.Animals
{


    public class Wolf : HostileAnimal
    {
        //control movement with arrows
        protected void Update()
        {

            if (Input.GetKey(KeyCode.UpArrow))
            {
                CurrentState = AnimalState.MOVING;
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                CurrentState = AnimalState.MOVING;
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                CurrentState = AnimalState.MOVING;
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                CurrentState = AnimalState.MOVING;
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }


        //attack animals in pen
        protected void Attack()
        {
            if (CurrentState == AnimalState.ATTACKING)
            {
                if (Pen.Animals.Count > 0)
                {
                    FriendlyAnimal animal = (FriendlyAnimal)Pen.Animals[0];
                    animal.Die();
                    Pen.Animals.Remove(animal);
                }
                else
                {
                    CurrentState = AnimalState.IDLE;
                }
            }
        }

    }
}