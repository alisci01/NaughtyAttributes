using System.Collections.Generic;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	public class _NaughtyComponent : MonoBehaviour
	{
	}

	[System.Serializable]
	public class MyClass
	{
		[CurveRange(0, 0, 1, 1, EColor.Green)]
		public AnimationCurve green;
	}

	[System.Serializable]
	public struct MyStruct
	{
	}
}
