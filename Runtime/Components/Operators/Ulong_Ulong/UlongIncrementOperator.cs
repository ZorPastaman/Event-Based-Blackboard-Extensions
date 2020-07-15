// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Ulong_Ulong
{
	[CustomLabelInfo(null, nameof(UInt64), 0)]
	[CustomLabelInfo(null, nameof(UInt64), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ulong) => (Ulong)/Ulong Increment Operator")]
	public sealed class UlongIncrementOperator : SingleReturnUnaryOperator<ulong, ulong>
	{
		protected override Func<ulong, ulong> operation => DefaultOperators.UlongIncrement;
	}
}
