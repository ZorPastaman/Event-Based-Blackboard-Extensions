// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.LongLong_Bool
{
	[CustomLabelInfo(null, nameof(Int64), 0)]
	[CustomLabelInfo(null, nameof(Int64), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Long, Long) => (Bool)/Long NotEqual Operator")]
	public sealed class LongNotEqualOperator : SingleReturnBinaryOperator<long, long, bool>
	{
		protected override Func<long, long, bool> operation => DefaultOperators.LongNotEqual;
	}
}
