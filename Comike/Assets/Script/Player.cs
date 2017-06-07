using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    SpriteRenderer spriteRenderer;

    //Rigidbody2Dコンポーネント
    Rigidbody2D rigidbody2d;

    //地面に着いているか
    bool isGrounded;

    //CharacterControllerコンポーネント
    //CharacterController controller;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //Rigibody2Dコンポーネントの取得
        rigidbody2d = GetComponent<Rigidbody2D>();
        //CharacterControllerの取得
        //controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update () {

        if(Time.timeScale == 1)
        {
            //移動ベクトル
            Vector3 velocity;

            //ベクトルを０に初期化
            velocity = Vector3.zero;

            //地面に接しているかを算出
            isGrounded = Physics2D.Raycast(
                transform.position, Vector2.down,
                1.0f, 1 << LayerMask.NameToLayer("Ground"));

            //右キーが押された
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //右に移動
                velocity.x += 0.1f;
                spriteRenderer.flipX = false;
                //画面端に出ないようにする
                if (transform.position.x > 6.5f)
                {
                    velocity.x -= 0.1f;
                }
            }

            //左キーが押された
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //左に移動
                velocity.x -= 0.1f;
                spriteRenderer.flipX = true;
                //画面端に出ないようにする
                if (transform.position.x < -6.5f)
                {
                    velocity.x += 0.1f;
                }
            }

            //スペースキーが押された
            if (/*controller.isGrounded &&*/ Input.GetKeyDown(KeyCode.Space))
            {
                //地面についているときだけジャンプ
                if (isGrounded)
                {
                    //上方向に力を加える
                    rigidbody2d.AddForce(Vector2.up * 500);
                }
            }

                //座標更新
                transform.position += velocity;

        }


    }


    void OnTriggerEnter2D(Collider2D c)
    {
        //Debug.Log("ﾏｯｺｯｺ");
    }
}
