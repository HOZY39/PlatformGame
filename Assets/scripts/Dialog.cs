using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogAktywacja;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dialogAktywacja && Input.GetKeyDown(KeyCode.Space))
        {
            dBox.SetActive(false);
            dialogAktywacja = false;
        }
    }
    public void ShowBox(string CoPowiedziec)
    {
        dialogAktywacja = true;
        dBox.SetActive(true);
        dText.text = CoPowiedziec;
    }
}
