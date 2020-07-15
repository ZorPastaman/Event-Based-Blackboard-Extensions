// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.LongLongLong_Long
{
	[CustomLabelInfo("Value", nameof(Int64), 0)]
	[CustomLabelInfo("Min", nameof(Int64), 1)]
	[CustomLabelInfo("Max", nameof(Int64), 2)]
	[CustomLabelInfo(null, nameof(Int64), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Long, Long, Long) => (Long)/Long Clamp Operator")]
	public sealed class LongClampOperator : SingleReturnTernaryOperator<long, long, long, long>
	{
		protected override Func<long, long, long, long> operation => DefaultOperators.LongClamp;
	}
}
