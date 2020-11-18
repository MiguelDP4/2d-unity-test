using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
  void OnCollisionEnter(Collision collision)
  {
    Debug.Log("this works");
  }
}
