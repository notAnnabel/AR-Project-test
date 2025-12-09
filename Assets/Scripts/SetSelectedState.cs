using UnityEngine;

public class SetSelectedState : MonoBehaviour
{
    public Material SelectedMaterial;
    private Material originalMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material; 
        // get a reference to the original prefab material
    }

    public void SetSelected(){
       gameObject.GetComponent<MeshRenderer>().material = SelectedMaterial;
    }

    public void SetUnselected(){
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
