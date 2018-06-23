﻿namespace TriggersTools.Asciify.ColorMine.Comparisons {
	/// <summary>
	/// Defines how comparison methods may be called
	/// </summary>
	public interface IColorSpaceComparison {
		/// <summary>
		/// Returns the difference between two colors given based on the specified defined in the called class.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns>Score based on similarity, the lower the score the closer the colors</returns>
		double Compare(ColorLab a, ColorLab b, bool quick = false);
	}
}