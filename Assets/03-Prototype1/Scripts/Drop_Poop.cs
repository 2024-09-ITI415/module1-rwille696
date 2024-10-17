using System.Collections;
using UnityEngine;

public class DropPrefab : MonoBehaviour
{
    public GameObject prefabToDrop;
    public Vector3 dropOffset = new Vector3(0, -1, 0);
    public float dropInterval = 2.0f;
    public string droppedLayer = "DroppedObject";  // Layer for dropped objects

    void Start()
    {
        if (prefabToDrop != null)
        {
            InvokeRepeating("DropObject", 0f, dropInterval);
        }
        else
        {
            Debug.LogError("No prefab assigned to drop!");
        }
    }

    void DropObject()
    {
        Vector3 dropPosition = transform.position + dropOffset;

        // Instantiate the prefab
        GameObject droppedObject = Instantiate(prefabToDrop, dropPosition, Quaternion.identity);

        // Assign the layer to the dropped prefab
        droppedObject.layer = LayerMask.NameToLayer(droppedLayer);
    }
}