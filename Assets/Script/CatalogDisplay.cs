using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CatalogDisplay : MonoBehaviour
{
    public CatItem page;
    public Text descriptionText;
    public Image artworkImage;
    public Text priceText;
    public Text catNumberText;
    // Use this for initialization
    void Start()
    {
        descriptionText.text = page.itemName;
        artworkImage.sprite = page.artwork;
        priceText.text = page.cost.ToString();
        catNumberText.text = page.itemNumber.ToString();
    }
}