using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using Game.Card;
using System.Linq;

public static class AutoCardGenerator
{
    private const string FolderPath = "Assets/Game/03.Resource/Card";
    private const string CardPath = "Assets/Game/03.Resource";

    [MenuItem("Tools/Card/Generate All Cards")]
    public static void GenerateCard()
    {
        // CardBase를 상속한 모든 클래스 찾기
        var derivedTypes = TypeCache.GetTypesDerivedFrom<CardBase>()
            .Where(t => !t.IsAbstract && !t.IsGenericType);

        if (!AssetDatabase.IsValidFolder($"{FolderPath}"))
        {
            AssetDatabase.CreateFolder(CardPath, "Card");
        }

        foreach (var type in derivedTypes)
        {
            // 인스턴스 생성
            var instance = ScriptableObject.CreateInstance(type) as CardBase;
            if (instance == null)
            {
                Debug.LogError($"[CardGenerator] Failed to create instance of {type.Name}.asset");
                continue;
            }

            instance.Generate();

            if (!AssetDatabase.IsValidFolder($"{FolderPath}/{instance.CardPath}"))
            {
                AssetDatabase.CreateFolder(FolderPath, instance.CardPath.ToString());
            }

            string assetPath = $"{FolderPath}/{instance.CardPath}/{instance.CardPath}_{instance.CardName}.asset";

            // 중복 체크
            var existing = AssetDatabase.LoadAssetAtPath<CardBase>(assetPath);
            if (existing != null)
            {
                Debug.Log($"[CardGenerator] Already exists: {type.Name}, skipping.");
                continue;
            }

            // 에셋 저장
            AssetDatabase.CreateAsset(instance, assetPath);
            Debug.Log($"[CardGenerator] Created: {type.Name}");
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.FocusProjectWindow();
    }
}

