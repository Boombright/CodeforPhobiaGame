using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
     public GameObject InventoryMenu;
     private bool menuActivated;
     public ItemSlot[] itemSlot;

     public ItemSO[] itemSO;

     void Start()
     {

     }

     void Update()
     {
          if(Input.GetButtonDown("Inventory") && menuActivated)
          {
               Time.timeScale = 1;
               InventoryMenu.SetActive(false);
               menuActivated = false;
          }
          else if(Input.GetButtonDown("Inventory") && !menuActivated)
          {
               Time.timeScale = 0;
               InventoryMenu.SetActive(true) ;
               menuActivated = true;
          }
     }

     public void UseItem(string itemName)
     {
          for (int i = 0; i < itemSO.Length; i++)
          {
               if(itemSO[i].itemName == itemName)
               {
                    itemSO[i].UseItem();
               }
          }
     }

     public int AddItem(string itemName, int quantity, Sprite itemSprite, string itemDescription)
     {
          for  (int i = 0; i < itemSlot.Length; i++)
          {
               if (itemSlot[i].isFull == false && itemSlot[i].itemName == itemName || itemSlot[i].quantity == 0)
               {
                    int leftOverItems = itemSlot[i].AddItem(itemName, quantity, itemSprite, itemDescription);
                    if(leftOverItems > 0)
                    {
                         leftOverItems = AddItem(itemName, leftOverItems, itemSprite, itemDescription);
                         
                    }
                    return leftOverItems;
               }
          }
          return quantity;
     }

     public void DeselectAllSlots()
     {
          for  (int i = 0; i < itemSlot.Length; i++)
          {
               itemSlot[i].selectShader.SetActive(false);
               itemSlot[i].thisItemSelected = false;
          }
     }

     
    /*public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();
    public List<GameObject> obj = new List<GameObject>();
    
    public Transform ItemContent;
    public GameObject InventoryItem;
    private void Awake()
    {
        Instance = this;
    }

   public void Add(Item item)
   {
        Items.Add(item);
   }

   public void Remove(Item item)
   {
        Items.Remove(item);
   }

   public void ListItem()
   {
        for (int i = 1; i <= Items.Count; ++i)
        {
            //GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj[i].transform.Find("Item/ItemName").GetComponent<Text>();
            //var itemicon = obj[i].transform.Find("Item/ItemIcon").GetComponent<Image>();
            Image itemicon = obj[i].GetComponent<Image>();

            itemName.text = Items[i].itemName;
            itemicon.sprite = Items[i].icon;
        }
        
   }*/
}
