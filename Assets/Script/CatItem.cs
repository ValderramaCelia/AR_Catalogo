using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Catalog Item")]

public class CatItem : ScriptableObject
    {
    public Sprite artwork;
    public string itemName;
    public string cost;
    public string itemNumber;

}
