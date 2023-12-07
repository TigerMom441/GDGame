using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOrReturn : MonoBehaviour
{
    //Where the enemy returns too
    public Transform HomeBase;
    //The player
    public Transform Player;
    //The enemy speed
    public float speed = 1.0f;

    //Ref To UI
    private UIScript ui;

    private Transform target;
    private Rigidbody2D rb;
    private bool _stop = false;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the rb
        rb = GetComponent<Rigidbody2D>();
        //set player as Target from the the start
        targetPlayer();
        ui = FindObjectOfType<UIScript>();

        if (ui)
        {
            Debug.Log(this.gameObject.name + " has a UI");
        }
    }


    // FixedUpdate is called after each physics calculations
    private void FixedUpdate()
    {
        if (ui.gameOver == false && !_stop)
        {

        //    //If the stop boolean is false, chase whichever target is set
        //    if (!_stop)
        //{
            rb.MovePosition(Vector2.Lerp(transform.position, target.position, Time.fixedDeltaTime * speed));
        //}
    }
    }

    //Target the player
    public void targetPlayer()
    {
        target = Player;
    }

    //Target the Home Base
    public void targetBase()
    {
        target = HomeBase;
    }

    //Switch enemy movement on or off
    public void stopPlayEnemy()
    {
        _stop = !_stop;
    }

}
