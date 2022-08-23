using UnityEngine;
using UnityEngine.UI;

public class ClickMapButton : MonoBehaviour
{
    public MapButton _mapButton;
    public Map _map;
    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        _map.changeCurentLocation(_mapButton);
    }
}
