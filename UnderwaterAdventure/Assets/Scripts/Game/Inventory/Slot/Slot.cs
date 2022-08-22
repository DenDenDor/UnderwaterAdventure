using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Sprite _questionSprite;
    [SerializeField] private Image _icon;
    private Item _item;

    public Item Item { get => _item; set => _item = value; }
    public event Action<Slot> OnClick; 
    public void AddItem(Item item)
    {
        SetCurrentItem(item,item.Sprite);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick?.Invoke(this);
    }
    public Sprite ReturnItemSprite()
    {
        return Item == null ? _questionSprite : Item.Sprite;
    }
    public void RemoveItem()
    {
        SetCurrentItem(null,null);
    }
    private void SetCurrentItem(Item item, Sprite sprite)
    {
        Item = item;
        _icon.sprite = sprite;
    }
    public void Replace(Vector3 position)
    {
        transform.position = position;
    }
}
