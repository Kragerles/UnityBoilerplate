using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private ManagerScript _manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _manager = GameObject.FindObjectOfType<ManagerScript>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        _manager.CollectCoin();
        Destroy(gameObject);
    }
}