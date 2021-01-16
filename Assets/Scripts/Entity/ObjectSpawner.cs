using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public Transform objectToTarget;

    public int spawnRate = 3;
    public int maximumObjects = 6;

    public GameObject dangerSign;
    public Canvas canvas;
    
    private int _objectCount;
    private float _spawnDistance = 150;
    private int _range = 15;

    // Start is called before the first frame update
    void Start()
    {
        _objectCount = 0;
        InvokeRepeating("SpawnIfNotMaximumObjects", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnIfNotMaximumObjects()
    {
        if (_objectCount < maximumObjects)
        {
            GameObject spawnedObject = Instantiate(objectToSpawn, GetRandomPositionWithinBounds(), Quaternion.identity);
            CreateAlertIcon(spawnedObject, dangerSign);
            _objectCount++;
        }
    }

    private Vector3 GetRandomPositionWithinBounds()
    {
        var x = Random.Range(-_range, _range);
        return new Vector3(x, objectToTarget.position.y - _spawnDistance, 0);
    }

    private void CreateAlertIcon(GameObject gameObject, GameObject icon)
    {
        RectTransform clone = Instantiate(icon, canvas.transform, false).GetComponent<RectTransform>();

        Vector2 canvasAnchor = Camera.main.WorldToViewportPoint(gameObject.transform.position);
        canvasAnchor.y = 0f;

        clone.anchorMin = canvasAnchor;
        clone.anchorMax = clone.anchorMin;

        clone.anchoredPosition = new Vector2(clone.localPosition.x, 50.0f);
        
        clone.anchorMin = new Vector2(0.5f, 0f);
        clone.anchorMax = clone.anchorMin;
    }
}
