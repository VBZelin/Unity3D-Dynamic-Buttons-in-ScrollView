using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class DynamicButtons : MonoBehaviour
{
    // Prefab
    GameObject buttonPrefab;

    // List of button names
    List<string> buttonNames = new List<string>();

    // Awake
    void Awake()
    {
        buttonPrefab = Resources.Load<GameObject>("Button");
    }

    // Start
    void Start()
    {
        buttonNames.Add("Jim");
        buttonNames.Add("Donna");
        buttonNames.Add("Tom");
        buttonNames.Add("Jason");
        buttonNames.Add("Andy");
        buttonNames.Add("Alex");
        buttonNames.Add("Billy");
        buttonNames.Add("David");
        buttonNames.Add("Jimmy");
        buttonNames.Add("Ken");
        buttonNames.Add("Aaron");
        buttonNames.Add("Ben");

        foreach (string str in buttonNames)
        {
            GameObject item = Instantiate(buttonPrefab) as GameObject;
            item.transform.SetParent(GameObject.Find("ScrollContent").transform);
            item.AddComponent<ButtonController>();

            Button itemBt = item.GetComponent<Button>();
            ButtonController buttonController = item.GetComponent<ButtonController>();
            item.GetComponentInChildren<Text>().text = str;
            buttonController.BtName = str;

            itemBt.onClick.AddListener(buttonController.ClickMe);
        }
    }
}
