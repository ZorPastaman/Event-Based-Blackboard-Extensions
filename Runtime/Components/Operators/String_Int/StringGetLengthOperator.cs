// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.String_Int
{
	[CustomLabelInfo(null, nameof(String), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(String) => (Int)/String Get Length Operator")]
	public sealed class StringGetLengthOperator : SingleReturnUnaryOperator<string, int>
	{
		protected override Func<string, int> operation => DefaultOperators.StringGetLength;
	}
}
