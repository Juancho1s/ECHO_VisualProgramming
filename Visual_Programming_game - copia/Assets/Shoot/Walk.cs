using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
   public Rigidbody rb;
   bool floorDetected = false;
   bool isJump = false;
   public float jumpForce = 5.0f;

   void Start()
   {
       rb = GetComponent<Rigidbody>();
       Cursor.lockState = CursorLockMode.Locked;
   }

   void Update()
   {
       Vector3 floor = transform.TransformDirection(Vector3.down);

       if (Physics.Raycast(transform.position, floor,  1.03f))
       {
            floorDetected = true;
       } 
       else
       {
            floorDetected = false;
       } 
 
       isJump = Input.GetButtonDown("Jump");
       if(isJump && floorDetected)
      {
         rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
      }
      
   }
}
