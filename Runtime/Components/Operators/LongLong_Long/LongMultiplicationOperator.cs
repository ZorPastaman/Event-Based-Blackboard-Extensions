// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.LongLong_Long
{
	[CustomLabelInfo(null, nameof(Int64), 0)]
	[CustomLabelInfo(null, nameof(Int64), 1)]
	[CustomLabelInfo(null, nameof(Int64), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Long, Long) => (Long)/Long Multiplication Operator")]
	public sealed class LongMultiplicationOperator : SingleReturnBinaryOperator<long, long, long>
	{
		protected override Func<long, long, long> operation => DefaultOperators.LongMultiplication;
	}
}
