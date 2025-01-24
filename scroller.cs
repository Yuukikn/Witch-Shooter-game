using UnityEngine;

public class scroller : MonoBehaviour
{
    [Range(-1f, 1f)]

    private Material mat;
    
    float scrollSpeed = 0.5f;
    float offset;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
