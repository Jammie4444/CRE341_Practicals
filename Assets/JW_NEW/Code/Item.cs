using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public int count;

    public Item(string itemName, int itemCount)
    {
        name = itemName;
        count = itemCount;
    }
}
