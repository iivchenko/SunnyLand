using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UpdateScore : MonoBehaviour
{
    private Text _text;

    public void Awake()
    {
        _text = GetComponent<Text>();
    }

    public void UpdateText(int score)
    {
        _text.text = string.Format("Score: {0}", score);
    }
}
