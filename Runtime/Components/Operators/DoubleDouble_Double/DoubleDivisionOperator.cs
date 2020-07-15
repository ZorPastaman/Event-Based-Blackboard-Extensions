// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.DoubleDouble_Double
{
	[CustomLabelInfo(null, nameof(Double), 0)]
	[CustomLabelInfo(null, nameof(Double), 1)]
	[CustomLabelInfo(null, nameof(Double), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double, Double) => (Double)/Double Division Operator")]
	public sealed class DoubleDivisionOperator : SingleReturnBinaryOperator<double, double, double>
	{
		protected override Func<double, double, double> operation => DefaultOperators.DoubleDivision;
	}
}
