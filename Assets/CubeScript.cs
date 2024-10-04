using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
　// ここからゲームに独自のプログラムを追加できます
　　// Start is called before the first frame update
　　void Start()
　　{
　　}
　　// Update is called once per frame
　　void Update()
　　{
　　}
　　void OnCollisionEnter(Collision collision)
　　//物体と物体がぶつかったときに以下のチェックが行われる
　　{
　　　if(collision.gameObject.tag=="ball") //ballとCubeが触れているなら
　　　　{
　　　　Destroy(this.gameObject); //Cubeを消す
　　　　}
　　}
　// ここまでゲームに独自のプログラムを追加できます
}