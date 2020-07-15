// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.UshortUshortUshort_Ushort
{
	[CustomLabelInfo("Value", nameof(UInt16), 0)]
	[CustomLabelInfo("Min", nameof(UInt16), 1)]
	[CustomLabelInfo("Max", nameof(UInt16), 2)]
	[CustomLabelInfo(null, nameof(UInt16), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Ushort, Ushort, Ushort) => (Ushort)/Ushort Clamp Operator")]
	public sealed class UshortClampOperator : SingleReturnTernaryOperator<ushort, ushort, ushort, ushort>
	{
		protected override Func<ushort, ushort, ushort, ushort> operation => DefaultOperators.UshortClamp;
	}
}
