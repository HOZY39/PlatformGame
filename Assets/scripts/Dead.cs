using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{

    public Transform Player;
    public int X;
    public int Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.tag = "Player";
        Player.transform.position = new Vector3(X, Y, 0);

    }
}
