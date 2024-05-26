
using UnityEngine;
public class FixYPosition : MonoBehaviour
{
    public float fixedYPosition = 1.5f; 

    private void Update()
    {
       
        transform.position = new Vector3(transform.position.x, fixedYPosition, transform.position.z);
    }
}