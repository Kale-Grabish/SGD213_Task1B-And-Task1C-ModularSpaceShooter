using UnityEngine;
using System.Collections;

public class MoveForwardConstantly : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
     
   
}
