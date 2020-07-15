// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Float_String
{
	[CustomLabelInfo(null, nameof(Single), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float) => (String)/Float ToString Operator")]
	public sealed class FloatToStringOperator : SingleReturnUnaryOperator<float, string>
	{
		protected override Func<float, string> operation => DefaultOperators.FloatToString;
	}
}
