using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // Bu scriptin ba�l� oldu�u GameObject
    public GameObject targetObject;

    // Prefab'ten olu�turulacak yeni obje
    public GameObject newPrefab;

    // Ba�lang��ta �a�r�l�r
    void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("L�tfen targetObject de�i�kenine bir GameObject atay�n!");
        }

        if (newPrefab == null)
        {
            Debug.LogError("L�tfen newPrefab de�i�kenine bir GameObject atay�n!");
        }
    }

    // Objeyi silip yeni obje olu�turan fonksiyon
    public void ReplaceObject()
    {
        // Mevcut objeyi sil
        Destroy(targetObject);

        // Yeni objeyi prefab'ten olu�tur
        GameObject newObject = Instantiate(newPrefab, targetObject.transform.position, targetObject.transform.rotation);

        // Yeni objeyi bir sonraki i�lemler i�in targetObject olarak ayarla
        targetObject = newObject;
    }
}
