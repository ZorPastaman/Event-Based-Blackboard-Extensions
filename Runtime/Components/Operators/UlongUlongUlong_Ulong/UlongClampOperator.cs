// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UlongUlongUlong_Ulong
{
	[CustomLabelInfo("Value", nameof(UInt64), 0)]
	[CustomLabelInfo("Min", nameof(UInt64), 1)]
	[CustomLabelInfo("Max", nameof(UInt64), 2)]
	[CustomLabelInfo(null, nameof(UInt64), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ulong, Ulong, Ulong) => (Ulong)/Ulong Clamp Operator")]
	public sealed class UlongClampOperator : SingleReturnTernaryOperator<ulong, ulong, ulong, ulong>
	{
		protected override Func<ulong, ulong, ulong, ulong> operation => DefaultOperators.UlongClamp;
	}
}
