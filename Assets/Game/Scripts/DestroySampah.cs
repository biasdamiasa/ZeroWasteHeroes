using UnityEngine;

public class DestroySampah : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 10); // untuk menghapus object sampah setelah 10 detik
    }

}
