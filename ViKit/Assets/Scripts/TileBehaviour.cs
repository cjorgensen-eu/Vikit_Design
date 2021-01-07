using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 

public class TileBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Material tileMaterial;
    public Material hoveredMaterial;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = tileMaterial;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetComponent<MeshRenderer>().material = hoveredMaterial;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<MeshRenderer>().material = tileMaterial;
    }

}
