using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject[] slots;
    public int[] items;

    public GameObject effect;
    public void PickUp(){
        for(int i = 0; i < slots.Length; i++){
            
            if (items[i] == 0){
                    Instantiate(effect, transform.position, Quaternion.identity);
                    items[i] = 1; 
                    Destroy(gameObject);
                break;
            }
        }
    }














//     public InventorySlot[] inventorySlots; 
//     public GameObject inventoryItemPrefab;

//     void searchEmptySlot(ISubsystem item){
//         for (int i = 0; i < inventorySlots.Length; i++){
//             InventorySLot slot = inventorySlots[i];
//             InventoryItem itemSlot = slot.GetComponentInChildren<InventoryItem>();

//             if (itemSlot != null){
//                 addNewItem(item, slot);
//                 return;
//             }
//         }
//     }
//     void addNewItem(Item item, InventorySlot slot){

//         GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
//         InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
//         inventoryItem.InitialiseItem(item);
//   }
// }
}
