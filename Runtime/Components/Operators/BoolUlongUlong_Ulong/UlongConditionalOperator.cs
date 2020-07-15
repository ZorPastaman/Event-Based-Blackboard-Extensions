// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolUlongUlong_Ulong
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(UInt64), 1)]
	[CustomLabelInfo("False", nameof(UInt64), 2)]
	[CustomLabelInfo(null, nameof(UInt64), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Ulong, Ulong) => (Ulong)/Ulong Conditional Operator")]
	public sealed class UlongConditionalOperator : SingleReturnTernaryOperator<bool, ulong, ulong, ulong>
	{
		protected override Func<bool, ulong, ulong, ulong> operation => DefaultOperators.UlongConditional;
	}
}
