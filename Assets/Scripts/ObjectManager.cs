using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    // Bu scriptin baðlý olduðu GameObject
    public GameObject targetObject;

    // Prefab'ten oluþturulacak yeni obje
    public GameObject newPrefab;

    // Baþlangýçta çaðrýlýr
    void Start()
    {
        if (targetObject == null)
        {
            Debug.LogError("Lütfen targetObject deðiþkenine bir GameObject atayýn!");
        }

        if (newPrefab == null)
        {
            Debug.LogError("Lütfen newPrefab deðiþkenine bir GameObject atayýn!");
        }
    }

    // Objeyi silip yeni obje oluþturan fonksiyon
    public void ReplaceObject()
    {
        // Mevcut objeyi sil
        Destroy(targetObject);

        // Yeni objeyi prefab'ten oluþtur
        GameObject newObject = Instantiate(newPrefab, targetObject.transform.position, targetObject.transform.rotation);

        // Yeni objeyi bir sonraki iþlemler için targetObject olarak ayarla
        targetObject = newObject;
    }
}
