using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private UIItem UIitem;
    private Inventory inventory;

    private void Awake()
    {
        inventory = new Inventory();
        UIitem.SetInventory(inventory);
    }

    public void CreateItem()
    {
        inventory.AddItem(CreateRandomItem());
        UIitem.RefreshInventory();
    }

    private Item CreateRandomItem()
    {
        return new Item { Color = GetRandomItemColor(), Shape = GetRandomItemShape() };
    }

    Item.ItemColor GetRandomItemColor()
    {
        var color = Enum.GetValues(typeof(Item.ItemColor));
        int randomColor = Random.Range(0, color.Length);
        Item.ItemColor newItemColor = (Item.ItemColor) randomColor;
        return newItemColor;
    }

    Item.ItemShape GetRandomItemShape()
    {
        var shape = Enum.GetValues(typeof(Item.ItemShape));
        int randomShape = Random.Range(0, shape.Length);
        Item.ItemShape newItemShape = (Item.ItemShape) randomShape;
        return newItemShape;
    }
}
    
    

 