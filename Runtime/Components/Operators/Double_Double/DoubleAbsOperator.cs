// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Double_Double
{
	[CustomLabelInfo(null, nameof(Double), 0)]
	[CustomLabelInfo(null, nameof(Double), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double) => (Double)/Double Abs Operator")]
	public sealed class DoubleAbsOperator : SingleReturnUnaryOperator<double, double>
	{
		protected override Func<double, double> operation => DefaultOperators.DoubleAbs;
	}
}
