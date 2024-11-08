using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour
{
    public string CoPowiedziec;
    private Dialog DMan;
    private bool Showbox;
    // Start is called before the first frame update
    void Start()
    {
        DMan = FindObjectOfType<Dialog>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DMan.ShowBox(CoPowiedziec);
            DMan.dialogAktywacja = true;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
                DMan.ShowBox(CoPowiedziec);
        }
    }
}
