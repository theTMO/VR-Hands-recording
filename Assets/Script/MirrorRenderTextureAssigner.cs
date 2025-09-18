using UnityEngine;

[ExecuteAlways]
[RequireComponent(typeof(Renderer))]
public class MirrorRenderTextureAssigner : MonoBehaviour
{
    public Camera mirrorCamera;
    public RenderTexture renderTexture;

    void Update()
    {
        if (mirrorCamera != null && renderTexture != null)
        {
            mirrorCamera.targetTexture = renderTexture;
            var renderer = GetComponent<Renderer>();
            if (renderer != null && renderer.sharedMaterial != null)
            {
                renderer.sharedMaterial.SetTexture("_MainTex", renderTexture);
            }
        }
    }
}
