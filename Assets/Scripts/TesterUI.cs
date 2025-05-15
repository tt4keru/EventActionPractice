using UnityEngine;
using UnityEngine.UI;

public class TesterUI : MonoBehaviour
{
	/// <summary>
	/// テスター
	/// </summary>
	[SerializeField]
	private Tester _tester;

	/// <summary>
	/// ボタン
	/// </summary>
	[SerializeField]
	private Button _subscribe_action_button;

	/// <summary>
	/// ボタン
	/// </summary>
	[SerializeField]
	private Button _subscribe_event_action_button;

	/// <summary>
	/// ボタン
	/// </summary>
	[SerializeField]
	private Button _fire_button;

	/// <summary>
	/// ボタン
	/// </summary>
	[SerializeField]
	private Button _clear_action_button;

	/// <summary>
	/// ボタン
	/// </summary>
	[SerializeField]
	private Button _clear_event_action_button;
	
	/// <summary>
	/// 開始処理
	/// </summary>
	private void Start()
	{
		_subscribe_action_button.onClick.AddListener(_tester.SubscribeAction);
		_subscribe_event_action_button.onClick.AddListener(_tester.SubscribeEventAction);
		_fire_button.onClick.AddListener(_tester.Fire);
		_clear_action_button.onClick.AddListener(_tester.Clear);
		_clear_event_action_button.onClick.AddListener(_tester.ClearEventAction);
	}
}
