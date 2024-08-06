using TMPro;
using UnityEngine;

public class stayRotation : MonoBehaviour
{
    private TextMeshPro textMeshPro;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        // Freeze the TextMeshPro object's rotation
        textMeshPro.transform.rotation = Quaternion.identity;
    }
}