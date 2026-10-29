using UnityEngine;
using TMPro;

public class CounterBehaviour : MonoBehaviour
{
    public TextMeshProUGUI scoreElement;

    private int counterValue = 0;

    public void Increment()
    {
        this.counterValue += GameManager.gInstance.GetIncrement();
        this.scoreElement.text = this.counterValue.ToString();
        GameManager.gInstance.SetPoints(this.counterValue);
    }
}