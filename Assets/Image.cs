using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Images : MonoBehaviour
{
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    public void ChangeImage(Sprite newSprite)
    {
        image.sprite = newSprite;
    }
}
