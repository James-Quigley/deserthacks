using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public string url = "52.41.27.101:443";
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = www.texture;
    }
}