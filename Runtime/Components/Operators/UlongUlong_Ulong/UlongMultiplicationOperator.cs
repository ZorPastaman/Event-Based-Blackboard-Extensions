// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UlongUlong_Ulong
{
	[CustomLabelInfo(null, nameof(UInt64), 0)]
	[CustomLabelInfo(null, nameof(UInt64), 1)]
	[CustomLabelInfo(null, nameof(UInt64), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ulong, Ulong) => (Ulong)/Ulong Multiplication Operator")]
	public sealed class UlongMultiplicationOperator : SingleReturnBinaryOperator<ulong, ulong, ulong>
	{
		protected override Func<ulong, ulong, ulong> operation => DefaultOperators.UlongMultiplication;
	}
}