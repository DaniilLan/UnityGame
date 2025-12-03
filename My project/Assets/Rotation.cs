using UnityEngine;

public class RotateCylinder : MonoBehaviour
{
    public float rotationSpeed = 30f; // градусов в секунду
    
    void Update()
    {
        // Вращение по оси Y
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}