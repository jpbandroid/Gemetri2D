using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{

    public Gamemodes Gamemode;
    public Speeds Speed;
    public Gravity gravity;
    public int State;

    void OnCollisionEnter2D(Collision2D collision) {
        try {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ChangeThroughPortal(Gamemode, Speed, gravity, State);
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
