// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;

namespace Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel
{
	/// <summary>
	/// Label info used in <see cref="CustomLabelAttribute"/>.
	/// </summary>
	/// <remarks>
	/// <see cref="CustomLabelAttribute"/> and <see cref="CustomLabelInfoAttribute"/> are linked with index.
	/// </remarks>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class CustomLabelInfoAttribute : Attribute
	{
		public readonly string name;
		public readonly string type;
		/// <summary>
		/// Link index.
		/// </summary>
		public readonly int index;

		public CustomLabelInfoAttribute(string name, string type, int index)
		{
			this.name = name;
			this.type = type;
			this.index = index;
		}
	}
}
