using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public int Boundary = 30;
 public int speed = 50;
 
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
        float left = Camera.main.WorldToScreenPoint(newPos).x + (theScreenWidth / 2) - Boundary;
        if (Camera.main.WorldToScreenPoint(player.transform.position).x > left)
     {
            newPos = player.transform.position;
     }
     
        float right = Camera.main.WorldToScreenPoint(newPos).x - (theScreenWidth / 2) + Boundary;
        if (Camera.main.WorldToScreenPoint(player.transform.position).x < right)
     {
         newPos = player.transform.position;
     }
     
        float up = Camera.main.WorldToScreenPoint(newPos).y + (theScreenHeight / 2) - Boundary;
        if (Camera.main.WorldToScreenPoint(player.transform.position).y > up)
        {
            newPos = player.transform.position;
        }

        float down = Camera.main.WorldToScreenPoint(newPos).y - (theScreenHeight / 2) + Boundary;
        if (Camera.main.WorldToScreenPoint(player.transform.position).y < down)
        {
            newPos = player.transform.position;
        }

        newPos.z = -10;
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime*2);


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
