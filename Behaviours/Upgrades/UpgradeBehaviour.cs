using UnityEngine;
using UnityEngine.UI;

public class UpgradeBehaviour : MonoBehaviour
{
    private Image buttonImage;
    private Button button;

    public void ReactToMouseEnter()
    {
        if (GameManager.gInstance.GetPoints() >= GameManager.gInstance.GetUpgradeValue())
        {
            this.buttonImage.color = Color.green;
            this.button.interactable = true;
            return;
        }
            
        this.buttonImage.color = Color.red;
    }

    public void ReactToMouseExit()
    {
        this.buttonImage.color = Color.gray;
    }

    public void UpgradeIncrement()
    {
        GameManager.gInstance.UpdateIncrementValue();
        GameManager.gInstance.UpdateScore();
        GameManager.gInstance.UpdateUpgradeValue();
        this.button.interactable = false;
    }

    public void Start()
    {
        this.button = this.GetComponent<Button>();
        this.buttonImage = this.GetComponent<Image>();
    }
}