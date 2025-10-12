using UnityEngine;

public class TrapScript : MonoBehaviour
{
    private PlayerScript manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.FindObjectOfType<PlayerScript>();
    }

    void OnTriggerEnter(Collider other)
    {
        manager.Reset();
    }
}
