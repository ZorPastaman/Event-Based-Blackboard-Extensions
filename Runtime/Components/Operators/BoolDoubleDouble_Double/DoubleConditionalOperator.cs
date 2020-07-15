// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolDoubleDouble_Double
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Double), 1)]
	[CustomLabelInfo("False", nameof(Double), 2)]
	[CustomLabelInfo(null, nameof(Double), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Double, Double) => (Double)/Double Conditional Operator")]
	public sealed class DoubleConditionalOperator : SingleReturnTernaryOperator<bool, double, double, double>
	{
		protected override Func<bool, double, double, double> operation => DefaultOperators.DoubleConditional;
	}
}
