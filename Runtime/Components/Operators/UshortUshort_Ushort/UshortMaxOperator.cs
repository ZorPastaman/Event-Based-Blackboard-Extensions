// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UshortUshort_Ushort
{
	[CustomLabelInfo(null, nameof(UInt16), 0)]
	[CustomLabelInfo(null, nameof(UInt16), 1)]
	[CustomLabelInfo(null, nameof(UInt16), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ushort, Ushort) => (Ushort)/Ushort Max Operator")]
	public sealed class UshortMaxOperator : SingleReturnBinaryOperator<ushort, ushort, ushort>
	{
		protected override Func<ushort, ushort, ushort> operation => DefaultOperators.UshortMax;
	}
}
