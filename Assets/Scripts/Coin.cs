using UnityEngine;

public class Coin : MonoBehaviour, ICollectable
{
    [SerializeField] private int price = 5;
    void PrintCurrentMoney(int currentMoney)
    {
        Debug.Log($"Current Money: {currentMoney}");
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMoneyChanged.AddListener(PrintCurrentMoney);
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
