// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolRectRect_Rect
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Rect), 1)]
	[CustomLabelInfo("False", nameof(Rect), 2)]
	[CustomLabelInfo(null, nameof(Rect), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Rect, Rect) => (Rect)/Rect Conditional Operator")]
	public sealed class RectConditionalOperator : SingleReturnTernaryOperator<bool, Rect, Rect, Rect>
	{
		protected override Func<bool, Rect, Rect, Rect> operation => DefaultOperators.RectConditional;
	}
}
