// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Double_String
{
	[CustomLabelInfo(null, nameof(Double), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Double) => (String)/Double ToString Operator")]
	public sealed class DoubleToStringOperator : SingleReturnUnaryOperator<double, string>
	{
		protected override Func<double, string> operation => DefaultOperators.DoubleToString;
	}
}
