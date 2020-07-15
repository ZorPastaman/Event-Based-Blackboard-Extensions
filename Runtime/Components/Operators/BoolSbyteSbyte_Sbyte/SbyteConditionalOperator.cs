// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolSbyteSbyte_Sbyte
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(SByte), 1)]
	[CustomLabelInfo("False", nameof(SByte), 2)]
	[CustomLabelInfo(null, nameof(SByte), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Sbyte, Sbyte) => (Sbyte)/Sbyte Conditional Operator")]
	public sealed class SbyteConditionalOperator : SingleReturnTernaryOperator<bool, sbyte, sbyte, sbyte>
	{
		protected override Func<bool, sbyte, sbyte, sbyte> operation => DefaultOperators.SbyteConditional;
	}
}
