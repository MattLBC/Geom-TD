using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class NodeUI : MonoBehaviour
{
    public GameObject ui; 
    private Node target; 

    public TMP_Text upgradeCost;
    public Button upgradeButton;

    public TMP_Text sellPrice;
    public Button sellButton;

    public void SetTarget(Node _target)
    {
        target = _target; 

        if (target.isUpgraded)
        {
            upgradeCost.text = "<b>UPGRADED</b>";
            upgradeButton.interactable = false;
        } else {
            upgradeCost.text = "<b>UPGRADE</b>" + "<br>" + "$" + target.turretBlueprint.upgradeCost;
            upgradeButton.interactable = true;
        }

        sellPrice.text = "<b>SELL</b>" + "<br>" + "$" + target.turretBlueprint.GetSellAmmount();

        transform.position = target.GetBuildPosition();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }

}
