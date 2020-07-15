// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectRect_Bool
{
	[CustomLabelInfo(null, nameof(Rect), 0)]
	[CustomLabelInfo(null, nameof(Rect), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Rect, Rect) => (Bool)/Rect Equal Operator")]
	public sealed class RectEqualOperator : SingleReturnBinaryOperator<Rect, Rect, bool>
	{
		protected override Func<Rect, Rect, bool> operation => DefaultOperators.RectEqual;
	}
}
