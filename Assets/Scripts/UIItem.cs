using UnityEngine;

public class UIItem : MonoBehaviour
{
    [SerializeField] private Transform items;
    [SerializeField] private Transform itemParent;
    private int itemPositionX = 0; 
    private int itemPositionY = 0;
    private int itemSlotCellSize = 2;
    private int maxInventoryWidth = 6;
    private Inventory inventory;
    public void SetInventory(Inventory inv)
    {
        inventory = inv;
    }

    public void RefreshInventory()
    {
        RectTransform itemRectTransform = 
            Instantiate(items, itemParent).GetComponent<RectTransform>();
        ItemSpacing(itemRectTransform);
        foreach (var item in inventory.GetItemList()) 
        {
            itemRectTransform.GetComponent<MeshRenderer>().material = item.GetMaterial();
            itemRectTransform.GetComponent<MeshFilter>().mesh = item.GetMesh();
        }
    }

    private void ItemSpacing(RectTransform rectTransform)
    {
        rectTransform.anchoredPosition = 
            new Vector2(itemPositionX * itemSlotCellSize, itemPositionY * itemSlotCellSize);
        itemPositionX++;
        if (itemPositionX >= maxInventoryWidth)
        {
            itemPositionX = 0;
            itemPositionY--;
        }
    }
}
