using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Shop : MonoBehaviour
{
   /* private Transform container;
    private Transform shopItemTemplate;
    private IShopCustomer shopCustomer;
        
    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = transform.Find("shopItemTemplate");
        //shopItemTemplate.gameObject.setActive(false);
    }
 
    private void Start()
    {
        CreateItemButton(Item.itemType.Armor_1, itemCost.GetSprite(Item.ItemType.Armor_1), "Armor 1", Item.GetCost(Item.ItemType.Armor_1), 0);
        CreateItemButton(Item.itemType.Armor_2, itemCost.GetSprite(Item.ItemType.Armor_1), "Armor 2", Item.GetCost(Item.ItemType.Armor_2), 0);

        Hide();
    }
    private void CreateItemButton(Item.ItemType itemType, Sprite itemSprite, string itemName, int itemCost)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<shopItemRectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button_UI>().ClickFunc = () =>
        {
            //Clicked on shop item button
            TryBuyItem(itemType);
        };
    }
    private void TryBuyItem(item.ItemType itemType)
    {
        shopCustomer.BoughtItem(itemType);
    }

    public void Show(IShopCustomer shopCustomer)
    {
        this.shopCustomer = shopCustomer;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }*/
}
