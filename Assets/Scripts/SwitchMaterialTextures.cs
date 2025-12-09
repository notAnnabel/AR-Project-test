using UnityEngine;
using System.Collections;

public class SwitchMaterialTextures : MonoBehaviour
{
    // array to hold textures to be shown in sequence
    public Texture[] NewTextures;

    private int TextureIndex = 0;
    // the index of the current texture to show

    private IEnumerator coroutine; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // define coroutine - including time delay
        coroutine = WaitAndSwitchImage(5.0f);
        // start coroutine
        StartCoroutine(coroutine);
        Debug.Log("Starting experience");
    }
    public void UpdateMaterialTexture(){
        // get reference to renderer
        Debug.Log("update material");
        Renderer renderer = GetComponent<Renderer>();
        if( renderer != null && NewTextures != null){
            TextureIndex ++;
            if(TextureIndex >=NewTextures.Length){
                TextureIndex = 0;
            }
            renderer.material.mainTexture = NewTextures[TextureIndex];
        }
    }
    // create a timed function call
    public IEnumerator WaitAndSwitchImage(float waitTime){
        while (true){
            yield return new WaitForSeconds(waitTime);
            UpdateMaterialTexture();
        }
    }
};


