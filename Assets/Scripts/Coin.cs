using Unity.Mathematics;
using UnityEngine;
using PrimeTween;

public class Coin : MonoBehaviour, ICollectable
{
    [SerializeField] private int price = 5;
    [SerializeField]public float rotationSpeed = 0.05f;

    private void Update()
    {
        transform.rotation *= quaternion.Euler(0, rotationSpeed, 0);
    }
    void PrintCurrentMoney(int currentMoney)
    {
        Debug.Log($"Current Money: {currentMoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
        Tween.PositionY(transform, transform.position.y + 0.25f, 1f,cycles: 9999, cycleMode: CycleMode.Yoyo);
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMoneyChanged.RemoveListener(PrintCurrentMoney);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Collect()
    {
        GameManager.Instance.Money = price;
        Destroy(gameObject);
    }
}
