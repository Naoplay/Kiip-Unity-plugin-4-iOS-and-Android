// Developed by Naoplay
// December 2011
// www.naoplay.com

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


#if UNITY_ANDROID
public class KiipBindingAndroid
{
	private static AndroidJavaObject _kiipPlugin;

	static KiipBindingAndroid()
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin = new AndroidJavaObject("com.naoplay.kiip.Binding");
	}

	
	// Initializes the Kiip object
	public static void init(string appKey, string appSecret)
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin.Call("kiipInit", appKey, appSecret);
	}
	
	// Starts the Kiip session
	public static void startSession()
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin.Call("kiipStartSession");
	}
	
	// Ends the Kiip session
	public static void endSession()
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin.Call("kiipEndSession");
	}

	// Unlocks an achievement
	public static void unlockAchievement(string achievementId)
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin.Call("kiipUnlockAchievement", achievementId);
	}
	
	// Updates the leaderboard
	public static void updateLeaderboard(int score, string leaderboardId)
	{
		if (Application.platform != RuntimePlatform.Android)
			return;

		_kiipPlugin.Call("kiipUpdateLeaderboard", score, leaderboardId);
	}
}
#endif
