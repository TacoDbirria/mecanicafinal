using UnityEngine;

public class matamalo : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto con el que chocó tiene el tag "piso" o "bala"
        if (other.CompareTag("piso") || other.CompareTag("Bala"))
        {
            // Destruye el objeto al que está asignado este script
            Destroy(gameObject);
        }
    }
}