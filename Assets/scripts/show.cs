using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class show : MonoBehaviour
{
    [SerializeField] 
    InputAction space = new InputAction(type: InputActionType.Button); // Define an input action for the space key
    private Renderer rend; // Renderer component to control visibility

    void OnEnable()
    {
        space.Enable(); // Enable the input action when the script is enabled
    }

    void OnDisable()
    {
        space.Disable(); // Disable the input action when the script is disabled
    }
        void Start()
    {
        rend = GetComponent<Renderer>(); // Get the Renderer component attached to the GameObject
    }
        
    void Update()
    {
        if (space.WasPressedThisFrame()) // Check if the space key was pressed this frame
        {
            rend.enabled = !rend.enabled; // Toggle the visibility of the object
        }
    }
}
