using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] 
    Vector3 amplitude = new Vector3(3f, 0f, 0f); // Oscillation amplitude
    [SerializeField] 
    float frequency = 1f; // Oscillation frequency in Hz
    [SerializeField] 
    float phaseDegrees = 0f; // Phase offset in degrees
    
    private Vector3 center; // Center position of oscillation
    private float phaseRad; // Phase offset in radians
    private const float x = Mathf.PI * 2; // Constant for 2*PI

    private void Start() 
    {
        center   =  transform.position;
        phaseRad = phaseDegrees * Mathf.Deg2Rad; // Convert phase from degrees to radians
    }

    private void Update() 
    {
        float s = Mathf.Sin(x * frequency * Time.time + phaseRad); // Calculate sine value based on time, frequency, and phase
        Vector3 offset = amplitude * s; // Calculate offset from center
        
        transform.position = center + offset; // Update world position
    }
}