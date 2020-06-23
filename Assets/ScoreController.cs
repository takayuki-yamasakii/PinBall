using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

	//スコアを表示するテキスト
	public GameObject scoreText;
	private int score = 0;

	// Use this for initialization
	void Start()
	{
		score = 0;

		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
	}
	//衝突時、Tag毎に得点を変更する

	void OnCollisionEnter(Collision other)
	{


		if (other.gameObject.tag  == "SmallStarTag" )
		{
			score += 1000;
			Debug.Log("Score1000:" + score);
		}
	    else if (other.gameObject.tag == "LargeStarTag")
		{
			score += 5000;
			Debug.Log("Score5000:" + score);
		}
		else if (other.gameObject.tag == "SmallCloudTag")
		{
			score += 3000;
			Debug.Log("Score3000:" + score);
		}
		else if (other.gameObject.tag == "LargeCloudTag")
		{
			score += 2000;
			Debug.Log("Score2000:" + score);
		}
		
	}

　　// Update is called once per frame
	void Update()
	{
		//ScoreTextに得点を表示する
		this.scoreText.GetComponent<Text>().text = string.Format("Score:" + score);
	}
}