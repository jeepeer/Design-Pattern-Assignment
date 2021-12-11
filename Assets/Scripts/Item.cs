using System;
using UnityEngine;

public class Item
{
    public ItemColor Color;
    public ItemShape Shape;

    public enum ItemColor
    {
        Blue,
        Red,
        Yellow
    }

    public Material GetMaterial()
    {
        switch (Color)
        {
            case ItemColor.Blue:
                return ItemAssets.Instance.blue;
            case ItemColor.Red:
                return ItemAssets.Instance.red;
            case ItemColor.Yellow:
                return ItemAssets.Instance.yellow;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
    public enum ItemShape
    {
        Box,
        Sphere,
        Capsule,
    }

    public Mesh GetMesh()
    {
        switch (Shape)
        {
            case ItemShape.Box:
                return ItemAssets.Instance.box;
            case ItemShape.Sphere:
                return ItemAssets.Instance.sphere;
            case ItemShape.Capsule:
                return ItemAssets.Instance.capsule;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
