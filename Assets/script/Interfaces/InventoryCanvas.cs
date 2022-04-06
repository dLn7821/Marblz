using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryCanvas : MonoBehaviour
{
    public GameObject inventory;
    public GameObject bag;
    public static bool isOpenedinventory;
    public static bool isOpenedbag;

    private void activate()
    {
        inventory.SetActive(true);
        bag.SetActive(true);
    }
    private void deactivate()
    {
        bag.SetActive(false);
        inventory.SetActive(false);

    }
    private void Awake()
    {
        StartCoroutine(Inventory());
    }
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!isOpenedinventory)
            {
                inventory.SetActive(true);
                isOpenedinventory = true;
            }
            else
            {
                inventory.SetActive(false);
                isOpenedinventory = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!isOpenedbag)
            {
                bag.SetActive(true);
                isOpenedbag = true;
            }
            else
            {
                bag.SetActive(false);
                isOpenedbag = false;
            }
        }

    }
    IEnumerator Inventory()
    {
        inventory.SetActive(true);
        bag.SetActive(true);
        yield return new WaitForSeconds(0);
        bag.SetActive(false);
        inventory.SetActive(false);
    }
    private void OnApplicationQuit()
    {
        inventory.SetActive(true);
        bag.SetActive(true);
    }

}

