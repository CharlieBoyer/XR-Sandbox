using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnDestroy()
    {
        GameObject.Find("Button").GetComponent<Button>().ReEnable();
    }
}
