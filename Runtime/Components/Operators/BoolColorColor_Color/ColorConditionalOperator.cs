// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolColorColor_Color
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Color), 1)]
	[CustomLabelInfo("False", nameof(Color), 2)]
	[CustomLabelInfo(null, nameof(Color), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Color, Color) => (Color)/Color Conditional Operator")]
	public sealed class ColorConditionalOperator : SingleReturnTernaryOperator<bool, Color, Color, Color>
	{
		protected override Func<bool, Color, Color, Color> operation => DefaultOperators.ColorConditional;
	}
}
