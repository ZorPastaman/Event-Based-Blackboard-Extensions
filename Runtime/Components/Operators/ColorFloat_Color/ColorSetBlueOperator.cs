// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ColorFloat_Color
{
	[CustomLabelInfo(null, nameof(Color), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Color), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Color, Float) => (Color)/Color Set Blue Operator")]
	public sealed class ColorSetBlueOperator : SingleReturnBinaryOperator<Color, float, Color>
	{
		protected override Func<Color, float, Color> operation => DefaultOperators.ColorSetBlue;
	}
}
