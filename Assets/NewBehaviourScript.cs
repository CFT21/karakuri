using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // オブジェクトの移動速度（Unityのエディタ側から自由に変更できます）
    [SerializeField] private float moveSpeed = 5.0f;

    // Startは最初のフレームが更新される前に呼び出されます
    void Start()
    {
        // 起動時にコンソールにメッセージを表示
        Debug.Log("移動スクリプトが起動しました！");
    }

    // Updateはフレームごとに1回呼び出されます
    void Update()
    {
        // キーボードの入力（矢印キーやWASD）を取得（-1.0 〜 1.0 の値が入ります）
        float horizontalInput = Input.GetAxis("Horizontal"); // 左右の入力
        float verticalInput = Input.GetAxis("Vertical");     // 前後の入力

        // 動かす方向を計算
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput);

        // オブジェクトの位置を移動させる（Time.deltaTimeをかけることでPCの性能に関わらず一定の速度になります）
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}