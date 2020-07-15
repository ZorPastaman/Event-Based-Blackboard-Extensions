// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.LongInt_Long
{
	[CustomLabelInfo(null, nameof(Int64), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Int64), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Long, Int) => (Long)/Long Right Shift Operator")]
	public sealed class LongIntRightShiftOperator : SingleReturnBinaryOperator<long, int, long>
	{
		protected override Func<long, int, long> operation => DefaultOperators.LongRightShift;
	}
}
