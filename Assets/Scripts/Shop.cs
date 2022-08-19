using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;

    public TMP_Text standardTurretCostText; 
    public TMP_Text missileLauncherCostText; 
    public TMP_Text laserBeamerCostText;
    

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
        standardTurretCostText.text = "$" + standardTurret.Cost.ToString();
        missileLauncherCostText.text = "$" + missileLauncher.Cost.ToString();
        laserBeamerCostText.text = "$" + laserBeamer.Cost.ToString();
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard turret selected");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileLauncher()
    {
        Debug.Log("Missle Launcher selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }

    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer selected");
        buildManager.SelectTurretToBuild(laserBeamer);
    }

}
