// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UshortUshort_Bool
{
	[CustomLabelInfo(null, nameof(UInt16), 0)]
	[CustomLabelInfo(null, nameof(UInt16), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ushort, Ushort) => (Ushort)/Ushort Greater Or Equal Operator")]
	public sealed class UshortGreaterOrEqualOperator : SingleReturnBinaryOperator<ushort, ushort, bool>
	{
		protected override Func<ushort, ushort, bool> operation => DefaultOperators.UshortGreaterOrEqual;
	}
}
