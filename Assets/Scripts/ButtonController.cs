using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Button name
    string btName;

    public string BtName
    {
        get { return btName; }
        set { btName = value; }
    }

    // Click Me
    public void ClickMe()
    {
        Debug.Log(BtName);
    }
}
