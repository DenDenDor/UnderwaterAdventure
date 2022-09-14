using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.EventSystems;
public class Slot : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite _questionSprite;
    [SerializeField] private Image _icon;
    private Item _item;
    private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
    private bool _isItemTaken;
    private bool _isCursorOnSlot;
    public Item Item { get => _item; set => _item = value; }
    public event Action<Slot> OnClick; 
    public void AddItem(Item item)
    {
        SetCurrentItem(item,item.Sprite);
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
    public void TryPuttingItem()
    {
        _icon.enabled = true;
        if (_isCursorOnSlot)
        {
            Debug.Log("PUT ITEM!");
             OnClick?.Invoke(this);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        //OnClick?.Invoke(this);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (_isItemTaken == false && _item.Sprite != null)
        {
            _isItemTaken = true;
            OnClick?.Invoke(this);
            _icon.enabled = false;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _isItemTaken = false;
        if (_isCursorOnSlot)
        {
            OnClick?.Invoke(this);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _isCursorOnSlot= true;
        StopCoroutine(CoolDown());
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        StartCoroutine(CoolDown());
    }
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(0.1f);
        _isCursorOnSlot =false;
    }
}
