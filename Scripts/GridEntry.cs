using UnityEngine;

namespace foxfluff.GridSystem
{
	/// <summary>
	/// GridEntry is a representation of objects attached to a grid, it will
	/// track if it's active or not, and what gameObject is attached.
	/// </summary>
	public class GridEntry
	{
		public GameObject Entry { get; private set; }
		public Vector3 Offset { get; private set; }
		public bool GetActive { get; private set; }
		public GameObject Wrapper { get; private set; }

		/// <summary>
		/// Created a new entry for an object in a Grid
		/// </summary>
		/// <param name="entry">The GameObject being attached to a point in the grid.</param>
		public GridEntry(GameObject entry = null)
		{
			Entry = entry;
			Wrapper = new GameObject();
			if (Entry)
			{
				SetActive(true);
				Entry.transform.SetParent(Wrapper.transform);
			}
		}

		/// <summary>
		/// Sets the active state of the entry.
		/// </summary>
		/// <param name="active">The active state of the object.</param>
		public void SetActive(bool active)
		{
			GetActive = active;
			Entry.SetActive(active);
		}

		/// <summary>
		/// Updates the transform offset of the object
		/// </summary>
		/// <param name="position">The new offset for the object relative to the coordinates position</param>
		public void UpdateOffset(Vector3 position)
		{
			// must first calculate the relative move since there won't be any reference to the parent grid

		}
	}
}