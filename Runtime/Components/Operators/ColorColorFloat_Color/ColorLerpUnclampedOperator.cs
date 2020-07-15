// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ColorColorFloat_Color
{
	[CustomLabelInfo("From", nameof(Color), 0)]
	[CustomLabelInfo("To", nameof(Color), 1)]
	[CustomLabelInfo("Time", nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Color), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Color, Color, Float) => (Color)/Color Lerp Unclamped Operator")]
	public sealed class ColorLerpUnclampedOperator : SingleReturnTernaryOperator<Color, Color, float, Color>
	{
		protected override Func<Color, Color, float, Color> operation => DefaultOperators.ColorLerpUnclamped;
	}
}
