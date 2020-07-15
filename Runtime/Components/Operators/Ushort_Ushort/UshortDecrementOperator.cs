// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Ushort_Ushort
{
	[CustomLabelInfo(null, nameof(UInt16), 0)]
	[CustomLabelInfo(null, nameof(UInt16), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ushort) => (Ushort)/Ushort Decrement Operator")]
	public sealed class UshortDecrementOperator : SingleReturnUnaryOperator<ushort, ushort>
	{
		protected override Func<ushort, ushort> operation => DefaultOperators.UshortDecrement;
	}
}
