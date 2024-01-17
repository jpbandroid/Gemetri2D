using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{

    public Gamemodes Gamemode;
    public Speeds Speed;
    public bool UprightGravity;
    public int State;

    void OnCollisionEnter2D(Collision2D collision) {
        try {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ChangeThroughPortal(Gamemode, Speed, UprightGravity, State);
        } catch {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
