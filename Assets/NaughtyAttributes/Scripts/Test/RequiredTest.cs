﻿using UnityEngine;

namespace NaughtyAttributes.Test
{
	public class RequiredTest : MonoBehaviour
	{
		[Required("Required A")]
		public Transform trans0;
		
		[Required("Required B")]
		public Transform trans1;
		
		[Required]
		public Transform trans2;
		
		[Required]
		public Transform trans3;


		public RequiredNest1 nest1;
	}

	[System.Serializable]
	public class RequiredNest1
	{
		[Required]
		[AllowNesting] // Because it's nested we need to explicitly allow nesting
		public Transform trans1;

		public RequiredNest2 nest2;
	}

	[System.Serializable]
	public class RequiredNest2
	{
		[Required("trans2 is invalid custom message - hohoho")]
		[AllowNesting] // Because it's nested we need to explicitly allow nesting
		public Transform trans2;
	}
}
