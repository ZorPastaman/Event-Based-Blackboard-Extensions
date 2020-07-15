// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Double_Int
{
	[CustomLabelInfo(null, nameof(Double), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double) => (Int)/Double Sign Operator")]
	public sealed class DoubleSignOperator : SingleReturnUnaryOperator<double, int>
	{
		protected override Func<double, int> operation => DefaultOperators.DoubleSign;
	}
}
