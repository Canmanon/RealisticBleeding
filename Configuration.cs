using System;

namespace RealisticBleeding
{
	[Serializable]
	public class Configuration
	{
		public int MaxActiveBloodDrips = 14;
		public float BloodAmountMultiplier = 1;
		public float BleedDurationMultiplier = 1;
		public float BloodStreakWidthMultiplier = 1;
	}
}