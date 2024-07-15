using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

public static bool lose = false;
void Awake()
{
lose = false;

}
private void OnTriggerEnter(Collider other)
{
if (other.gameObject.tag == "Сubik")
{
lose = true;
}
}

}

