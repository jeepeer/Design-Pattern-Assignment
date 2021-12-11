using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public Material blue;
    public Material red;
    public Material yellow;
    
    public Mesh box;
    public Mesh sphere;
    public Mesh capsule;

    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}
