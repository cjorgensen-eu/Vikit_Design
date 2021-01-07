using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SceneControl : MonoBehaviour
{
    // public members

    public GameObject tilePrefab;

    // private members

    private float moduleWidth = 1.2f;
    private float wallWidth = 0.1f;

    private int nbWidth = 2;
    private int nbLength = 5;

    // Start is called before the first frame update
    void Start()
    {
        addPhysicsRaycaster();
    }

    void addPhysicsRaycaster()
    {
        PhysicsRaycaster physicsRaycaster = GameObject.FindObjectOfType<PhysicsRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<PhysicsRaycaster>();
        }
    }

    public void setNbWidth(String val)
    {
        if (!int.TryParse(val, out nbWidth))
            throw new ArgumentException("val must be a string of an integer");
    }

    public void setNbLength(String val)
    {
        if (!int.TryParse(val, out nbLength))
            throw new ArgumentException("val must be a string of an integer");
    }

    public void PlaceTiles()
    {
        float startX = (nbWidth * moduleWidth + (nbWidth + 1) * wallWidth) / -2;
        float startZ = 0;

        for (int i = 0; i < nbWidth; i++)
        {
            for (int j = 0; j < nbLength; j++)
            {
                float posX = startX + wallWidth * (i + 1) + moduleWidth * (i + 0.5f);
                float posZ = startZ + wallWidth * (j + 1) + moduleWidth * (j + 0.5f);

                Instantiate(tilePrefab, new Vector3(posX, 0.5f, posZ), Quaternion.identity);

                Debug.Log("Spawning tile at (" + posX + ", " + posZ + ")");
            }
        }
    }

}