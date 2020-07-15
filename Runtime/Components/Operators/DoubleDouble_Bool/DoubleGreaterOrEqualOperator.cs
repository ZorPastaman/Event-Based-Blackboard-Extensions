// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.DoubleDouble_Bool
{
	[CustomLabelInfo(null, nameof(Double), 0)]
	[CustomLabelInfo(null, nameof(Double), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double, Double) => (Bool)/Double Greater Or Equal Operator")]
	public sealed class DoubleGreaterOrEqualOperator : SingleReturnBinaryOperator<double, double, bool>
	{
		protected override Func<double, double, bool> operation => DefaultOperators.DoubleGreaterOrEqual;
	}
}
