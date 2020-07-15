// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;

namespace Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel
{
	/// <summary>
	/// Edits a label of a property with an info from <see cref="CustomLabelInfoAttribute"/>.
	/// </summary>
	/// <remarks>
	/// <see cref="CustomLabelAttribute"/> and <see cref="CustomLabelInfoAttribute"/> are linked with index.
	/// </remarks>
	public sealed class CustomLabelAttribute : PropertyAttribute
	{
		/// <summary>
		/// Link index.
		/// </summary>
		public readonly int index;

		public CustomLabelAttribute(int index)
		{
			this.index = index;
		}
	}
}
