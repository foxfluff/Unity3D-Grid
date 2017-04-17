using UnityEngine;

namespace foxfluff.GridSystem
{
	public class GridEntry
	{
		public GameObject Entry { get; private set; }
		public bool GetActive { get; private set; }

		public GridEntry(GameObject entry = null)
		{
			Entry = entry;
			if (!entry)
				GetActive = true;
		}

		public void SetActive(bool active)
		{
			GetActive = active;
		}
	}
}