﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public int Boundary = 30;
 public int speed = 5;
 
 private int theScreenWidth;
 private int theScreenHeight;

    public GameObject player;
 
 void Start() 
 {
     theScreenWidth = Screen.width;
     theScreenHeight = Screen.height;
 }
 
 void Update() 
 {
        Vector3 newPos = transform.position;
        float left = Camera.main.WorldToScreenPoint(newPos).x + (theScreenWidth / 2) - 100;
        if (Camera.main.WorldToScreenPoint(player.transform.position).x > left)
     {
            newPos.x += speed * Time.deltaTime;
            transform.position = newPos;
     }
     
        float right = Camera.main.WorldToScreenPoint(newPos).x - (theScreenWidth / 2) + 100;
        if (Camera.main.WorldToScreenPoint(player.transform.position).x < right)
     {
         newPos.x -= speed * Time.deltaTime;
            transform.position = newPos;
     }
     
     /*if (player.transform.position.y > theScreenHeight - Boundary)
     {
         newPos.y += speed * Time.deltaTime;
            transform.position = newPos;
     }
     
     if (player.transform.position.y < 0 + Boundary)
     {
         newPos.y -= speed * Time.deltaTime;
            transform.position = newPos;
     }*/


     
 }    
}