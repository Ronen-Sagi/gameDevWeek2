using UnityEngine;

public class Pulse : MonoBehaviour
{
    [SerializeField] 
    float pulseSpeed = 1f; // Speed of pulsing effect
    
    [SerializeField] 
    float scaleAmplitude = 0.5f; // Amplitude of scaling effect
    
    private Vector3 startScale;
    
    void Start()
    {
        startScale = transform.localScale; // Store the initial scale of the object
    }

    void Update()
    {
        float scale = Mathf.Sin(Time.time * pulseSpeed); // Calculate scale factor using sine wave
        float normalizedScale = scale * scaleAmplitude; // Normalize scale to desired amplitude
        float scaleFactor = 1 + normalizedScale; // Calculate final scale factor
        transform.localScale = startScale * scaleFactor; // Update the local scale of the object
    }
}
