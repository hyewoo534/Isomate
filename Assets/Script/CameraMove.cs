using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   public float smoothSpeed = 2;
   private Transform playertarget;
   public float minX, maxX, minY, maxY;


   private void Start()
   {
      playertarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
   }


   private void LateUpdate()
   {
      float playerX = Mathf.Clamp(playertarget.position.x, minX, maxX);
      float playerY = Mathf.Clamp(playertarget.position.y, minY, maxY);

      transform.position = Vector3.MoveTowards(transform.position,
         new Vector3(playerX, playerY, transform.position.z),
         smoothSpeed * Time.deltaTime);
   }
}
