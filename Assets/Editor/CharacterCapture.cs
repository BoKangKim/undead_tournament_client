using UnityEngine;
using UnityEditor;
using System.IO;

public class CharacterCapture : MonoBehaviour
{
    [MenuItem("Tools/Capture Character Sprite")]
    static void CaptureSprite()
    {
        // 대상 카메라 가져오기
        Camera cam = Camera.main;
        RenderTexture rt = new RenderTexture(512, 512, 24);
        cam.targetTexture = rt;

        Texture2D screenShot = new Texture2D(512, 512, TextureFormat.RGBA32, false);
        cam.Render();

        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, 512, 512), 0, 0);
        screenShot.Apply();

        cam.targetTexture = null;
        RenderTexture.active = null;
        DestroyImmediate(rt);

        // 저장 경로
        byte[] bytes = screenShot.EncodeToPNG();
        string path = "Assets/UnityAsset/Game/03.Resource/CharacterSprite" + "/CapturedSprite.png";
        File.WriteAllBytes(path, bytes);

        Debug.Log($"Sprite saved to {path}");
        AssetDatabase.Refresh();
    }
}
