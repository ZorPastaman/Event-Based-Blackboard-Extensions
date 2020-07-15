// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UlongUlong_Bool
{
	[CustomLabelInfo(null, nameof(UInt64), 0)]
	[CustomLabelInfo(null, nameof(UInt64), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ulong, Ulong) => (Bool)/Ulong Greater Or Equal Operator")]
	public sealed class UlongGreaterOrEqualOperator : SingleReturnBinaryOperator<ulong, ulong, bool>
	{
		protected override Func<ulong, ulong, bool> operation => DefaultOperators.UlongGreaterOrEqual;
	}
}
