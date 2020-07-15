// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.DoubleDoubleDouble_Double
{
	[CustomLabelInfo("Value", nameof(Double), 0)]
	[CustomLabelInfo("Min", nameof(Double), 1)]
	[CustomLabelInfo("Max", nameof(Double), 2)]
	[CustomLabelInfo(null, nameof(Double), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double, Double, Double) => (Double)/Double Clamp Operator")]
	public sealed class DoubleClampOperator : SingleReturnTernaryOperator<double, double, double, double>
	{
		protected override Func<double, double, double, double> operation => DefaultOperators.DoubleClamp;
	}
}
