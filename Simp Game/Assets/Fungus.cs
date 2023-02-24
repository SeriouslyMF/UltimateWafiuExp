using UnityEngine;
using System.Collections;
using Steamworks;
using Fungus;

namespace Fungus
{
	[CommandInfo("Scripting",
		"Set Achievement",
		"Activates (or alternatively clears) the achievement .")]
	[AddComponentMenu("")]
	public class SetAchievement1 : Command
	{
		//[VariableProperty(typeof(BooleanVariable))]

		public bool SetAchievement = true;
		public string achievement = "";


		public override void OnEnter()
		{
			if (SteamManager.Initialized)
			{
				if (SetAchievement)
				{
					SteamUserStats.SetAchievement(achievement);
				}
				else
				{
					SteamUserStats.ClearAchievement(achievement);
				}
				bool yes = SteamUserStats.StoreStats();
				Debug.Log(yes);
			}

			Continue();

		}

	}

}