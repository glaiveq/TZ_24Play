using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesStack : MonoBehaviour
{

    public Transform StackParent;

    private Vector3 newPos;

    private void OnTriggerEnter(Collider other) { 
    
        if (other.CompareTag("Cube"))
        {
            Transform Cube = other.transform.parent;
            Cube.gameObject.layer = LayerMask.NameToLayer("CubeStacked");
            other.gameObject.layer = LayerMask.NameToLayer("CubeStacked");

            newPos = StackParent.localPosition;
            newPos.y += 1;
            newPos.x = 0;
            newPos.z = 0;
            StackParent.localPosition = newPos;

            Cube.SetParent(StackParent);
            newPos.y *= -1;
            Cube.localPosition = newPos;
            Cube.localRotation = Quaternion.identity;
            
        }
        
    }

}
