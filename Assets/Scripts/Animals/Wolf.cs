using System.Linq.Expressions;
using System.ComponentModel;
using System.Transactions;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson_6.Animals
{


    public class Wolf : HostileAnimal
    {
        private Vector3 initialoffset;
        private Vector3 cameraposition;
        public void Start()
        {
            speed = 10.0f;
        }
        //make Main camera follow the wolf as third player game
        protected void LateUpdate()
        {

            initialoffset = new Vector3(0, 10, -10);
            cameraposition = transform.position + initialoffset;
            Camera.main.transform.position = cameraposition;
            Camera.main.transform.LookAt(transform.position);
        }
        //control movement with arrows
        //oncolission with wolf and the friendly animal kill the friendly animal.

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
            else
            {
                CurrentState = AnimalState.IDLE;
            }
            // The currents state is attacking when i press space
            if (Input.GetKeyDown(KeyCode.Space))
            {
                CurrentState = AnimalState.ATTACKING;
                UnityEngine.Debug.Log("i press space");

            }
            else
            {
                CurrentState = AnimalState.IDLE;
            }

        }
        //when wolf touch an friendly animal remove the friendly animal from the pen and kill it
        void OnCollisionEnter(Collision col)
        {
            
            if (col.gameObject.name == "Cat")
            {
UnityEngine.Debug.Log("some text");

                //destroy the object
                Destroy(col.gameObject);
            }
          
        }



    }
}