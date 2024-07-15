using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentControl : MonoBehaviour
{
 public Rigidbody rigidbody;

 public int maxSpeed=5;

 public float acceleration=3.0f;//ускорение
 void Accelerate(Vector3 direction){    //получаем направление ускорения
    Vector3 horizontalVelocity = rigidbody.velocity;
    horizontalVelocity.y=0;
    float currentSpeed=horizontalVelocity.magnitude;  //находим ускорение
    if (currentSpeed<maxSpeed){  //чтобы не ускорялся до бесконечности
        rigidbody.AddForce(direction* acceleration*Time.deltaTime, ForceMode.VelocityChange);  //направлене в котором ускоряемся
    
    }

 }

    void Update(){
        if (Input.GetKey(KeyCode.A)){
            Accelerate(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D)){
            Accelerate(Vector3.right);
        }



    }
}
