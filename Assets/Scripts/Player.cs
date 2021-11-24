using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    bool IsAlive = true;


    Rigidbody2D MyRigitbody;
    Animator MyAnimator;
    CapsuleCollider2D MyCapsuleCollider2D;
    BoxCollider2D MyBoxCollider2D;


    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float ClimbSpeed = 5f;

    [SerializeField] Vector2 DeadVectorSpeed = new Vector2(50f, 50f);
    [SerializeField] string LevelReset;


    [SerializeField] AudioClip JumpAudio;
    [SerializeField] AudioClip DeathAudio;

    [SerializeField] int PlayerLives = 3;
    public int Gems { get; set; } = 0;
    Joystick joystick;




    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        MyRigitbody = GetComponent<Rigidbody2D>();
        MyAnimator = GetComponent<Animator>();
        MyCapsuleCollider2D = GetComponent<CapsuleCollider2D>();
        MyBoxCollider2D = GetComponent<BoxCollider2D>();

        joystick = FindObjectOfType<Joystick>();
        if (PlayerPrefs.HasKey("PlayerSpeed") && PlayerPrefs.HasKey("PlayerJump"))
        {
            runSpeed = PlayerPrefs.GetFloat("PlayerSpeed");
            jumpSpeed = PlayerPrefs.GetFloat("PlayerJump");

        }

    }

    // Update is called once per frame
    void Update()
    {


        if (!IsAlive) { return; }

        Run();
        Jump();
        Climb();
        FlipSpride();
        Dead();

    }
    public void Dead()
    {
        if (MyCapsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Enemy", "HarmLayer")))
        {
            IsAlive = false;
            MyAnimator.SetBool("Dying", true);
            MyRigitbody.velocity = DeadVectorSpeed;
            AudioSource.PlayClipAtPoint(DeathAudio, transform.position);
            FindObjectOfType<GameSession>().ProsessPlayerDeath();

        }
    }


    private void Run()
    {

        float controlThrow = joystick.Horizontal;/*Input.GetAxis("Horizontal");*/
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, MyRigitbody.velocity.y);
        MyRigitbody.velocity = playerVelocity;

        bool playerhashorizontalspeed = Mathf.Abs(MyRigitbody.velocity.x) > Mathf.Epsilon;
        MyAnimator.SetBool("Running", playerhashorizontalspeed);
    }
    void Jump()
    {
        if (!MyBoxCollider2D.IsTouchingLayers(LayerMask.GetMask("Ground"))) { return; }
        if (/*Input.GetButton("Jump")*/ joystick.Vertical > 0.3f)
        {
            Vector2 JumpvelocityToAdd = new Vector2(0f, jumpSpeed);
            MyRigitbody.velocity = JumpvelocityToAdd;
            AudioSource.PlayClipAtPoint(JumpAudio, transform.position);


        }
    }
    void Climb()
    {
        if (!MyCapsuleCollider2D.IsTouchingLayers(LayerMask.GetMask("Climbing")))
        {
            MyAnimator.SetBool("Climbing", false);
            return;
        }
        float controlThrow = Input.GetAxis("Vertical");
        Vector2 playerVelocity = new Vector2(MyRigitbody.velocity.x, controlThrow * ClimbSpeed);
        MyRigitbody.velocity = playerVelocity;

        bool playerhashorizontalspeed = Mathf.Abs(MyRigitbody.velocity.y) > Mathf.Epsilon;
        MyAnimator.SetBool("Climbing", playerhashorizontalspeed);
    }
    private void FlipSpride()
    {
        bool playerhashorizontalspeed = Mathf.Abs(MyRigitbody.velocity.x) > Mathf.Epsilon;
        if (playerhashorizontalspeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(MyRigitbody.velocity.x), 1f);
        }
    }

    public float GetSpeed() { return this.runSpeed; }
    public void SetSpeed(float value) { this.runSpeed = value; }

    public void SetAlive(bool command) => this.IsAlive = command;

}
