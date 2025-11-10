using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    [SerializeField] 
    Vector3 rotationSpeed = new Vector3(0f, 0f, 90f); // Rotation speed in degrees per second

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime); // Rotate the object based on rotation speed and time
    }
}
