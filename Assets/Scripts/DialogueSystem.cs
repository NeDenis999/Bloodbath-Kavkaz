using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DialogueSystem : MonoBehaviour
{
    public TextAsset asset;

    int i = 0;

    public TextMeshProUGUI _name;
    public TextMeshProUGUI _text;
    public Image character_image;

    public int[] char_ID;
    public Sprite[] char_Sprites;

    [SerializeField] private UnityEvent _event;

    DialogueSettings dialogue;

    private void Start()
    {
        dialogue = DialogueSettings.Load(asset);
        Initialization();
        //character_image.GetComponent<Animator>().SetTrigger("go");
    }

    private void Update()
    {
        Inputing();
    }

    private void Initialization()
    {
        _name.text = dialogue.nodes[i].Name;
        _text.text = dialogue.nodes[i].Text;
        character_image.sprite = char_Sprites[char_ID[i]];
    }

    private void Inputing()
    {
        if (Input.GetMouseButtonDown(1)) Next();
    }

    public void Next()
    {
        if (i < dialogue.nodes.Length - 1)
        {
            i++;
            Initialization();
            //character_image.GetComponent<Animator>().SetTrigger("go");
        }
        else if (i == dialogue.nodes.Length - 1)
        {
            //i = dialogue.nodes.Length - 1;
            _event.Invoke();
            gameObject.SetActive(false);
        }
    }
}
