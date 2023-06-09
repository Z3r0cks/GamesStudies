using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : NetworkBehaviour
{
   void HandleMovement()
   {
      if (isLocalPlayer)
      {
         float moveHorizontal = Input.GetAxis("Horizontal");
         float moveVertical = Input.GetAxis("Vertical");
         Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
         transform.position = transform.position + movement * Time.deltaTime * 10;
      }

   }
   void Update()
   {
      HandleMovement();
   }
}
