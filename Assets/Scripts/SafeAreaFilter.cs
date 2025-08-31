using UnityEngine;

[ExecuteAlways]
public class SafeAreaFitter : MonoBehaviour
{
    RectTransform _rt;
    Rect _lastSafe;

    void Awake() => _rt = GetComponent<RectTransform>();
    void OnEnable() => Apply();

    void Update()
    {
        if (Screen.safeArea != _lastSafe) Apply();
    }

    void Apply()
    {
        _lastSafe = Screen.safeArea;

        Vector2 anchorMin = _lastSafe.position;
        Vector2 anchorMax = _lastSafe.position + _lastSafe.size;

        anchorMin.x /= Screen.width;
        anchorMin.y /= Screen.height;
        anchorMax.x /= Screen.width;
        anchorMax.y /= Screen.height;

        _rt.anchorMin = anchorMin;
        _rt.anchorMax = anchorMax;
        _rt.offsetMin = Vector2.zero;
        _rt.offsetMax = Vector2.zero;
    }
}
