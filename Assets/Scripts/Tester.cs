using System;
using UnityEngine;

public class Tester : MonoBehaviour
{
	/// <summary>
	/// Action
	/// </summary>
	public Action action;

	/// <summary>
	/// event Action
	/// </summary>
	public event Action eventAction;

	/// <summary>
	/// Actionに登録
	/// </summary>
	public void SubscribeAction()
	{
		Debug.Log("Actionに登録します。");
		action += _OnActionCalled;
	}

	/// <summary>
	/// event Actionに登録
	/// </summary>
	public void SubscribeEventAction()
	{
		Debug.Log("event Actionに登録します。");
		eventAction += _OnEventActionCalled;
	}

	/// <summary>
	/// 呼び出し
	/// </summary>
	public void Fire()
	{
		action?.Invoke();
		eventAction?.Invoke();
	}

	/// <summary>
	/// Actionをクリア
	/// </summary>
	public void Clear()
	{
		Debug.Log("Actionをクリアします。");
		action = null;
	}

	/// <summary>
	/// event Actionをクリア
	/// </summary>
	public void ClearEventAction()
	{
		Debug.Log("event Actionをクリアします。");

		if (eventAction == null) {
			return;
		}

		// GetInvocationList()で登録されたデリゲート一覧を取得
		foreach (Delegate d in eventAction.GetInvocationList())
		{
			eventAction -= (Action)d;
		}
	}

	/// <summary>
	/// Actionが呼び出された時の処理
	/// </summary>
	private void _OnActionCalled()
	{
		Debug.Log("Actionが呼び出されました。");
	}

	/// <summary>
	/// event Actionが呼び出された時の処理
	/// </summary>
	private void _OnEventActionCalled()
	{
		Debug.Log("event Actionが呼び出されました。");
	}
}
