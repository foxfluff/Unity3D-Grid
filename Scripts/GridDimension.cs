using System;
using UnityEngine;

namespace foxfluff.GridSystem
{
	[Serializable]
	public struct GridDimension
	{
		[SerializeField] int cellCount;
		[SerializeField] float cellDistance;

		public int CellCount { get { return cellCount; } }
		public float CellDistance { get { return cellDistance; } }
	}
}