using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int counterLive;
    public bool gameOver = false;
    //private UIManager _uiManager;
    private LiveBar _liveBar;
    private const int liveMax = 100;
    private const int liveMin = 0;
    [SerializeField]
    private float _spped = 3.5f;
    private CollisionPlayer _collision;
    private float forceJump = 8f;
    private Rigidbody _rb;
    private AnimationPlayer _animPlayer;

    // Start is called before the first frame update
    void Start()
    {
        //_uiManager = Component.FindObjectOfType<UIManager>();
        _liveBar = Component.FindObjectOfType<LiveBar>();
        _liveBar.liveMax(liveMax);
        _liveBar.liveMin(liveMin);

        _collision = GetComponent<CollisionPlayer>();
        _rb = GetComponent<Rigidbody>();
        _animPlayer = GetComponent<AnimationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        live();
        jump();
        movement();

    }

    private void live()
    {
        _liveBar.liveValue(counterLive);
        if (counterLive < 1)
        {

            gameOver = true;
        }
    }

    private void movement()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        _animPlayer.SetHorizontal(inputHorizontal);
        _animPlayer.SetVertical(inputVertical);

        Vector3 move = new Vector3(inputHorizontal, 0, inputVertical).normalized;
        transform.Translate(move * Time.deltaTime * _spped);


    }

    private void jump()
    {
        if (_collision.touchingFloor && Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(0, forceJump, 0, ForceMode.Impulse);
            _animPlayer.SetJump(_collision.touchingFloor);
        }


    }

}
