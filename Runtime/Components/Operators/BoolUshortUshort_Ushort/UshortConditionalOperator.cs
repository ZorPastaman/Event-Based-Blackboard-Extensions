// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolUshortUshort_Ushort
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(UInt16), 1)]
	[CustomLabelInfo("False", nameof(UInt16), 2)]
	[CustomLabelInfo(null, nameof(UInt16), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Ushort, Ushort) => (Ushort)/Ushort Conditional Operator")]
	public sealed class UshortConditionalOperator : SingleReturnTernaryOperator<bool, ushort, ushort, ushort>
	{
		protected override Func<bool, ushort, ushort, ushort> operation => DefaultOperators.UshortConditional;
	}
}
