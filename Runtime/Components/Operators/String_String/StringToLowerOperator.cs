// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.String_String
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo(null, nameof(String), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String) => (String)/String To Lower Operator")]
	public sealed class StringToLowerOperator : SingleReturnUnaryOperator<string, string>
	{
		protected override Func<string, string> operation => DefaultOperators.StringToLower;
	}
}
