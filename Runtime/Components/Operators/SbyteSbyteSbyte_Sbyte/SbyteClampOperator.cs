// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.SbyteSbyteSbyte_Sbyte
{
	[CustomLabelInfo("Value", nameof(SByte), 0)]
	[CustomLabelInfo("Min", nameof(SByte), 1)]
	[CustomLabelInfo("Max", nameof(SByte), 2)]
	[CustomLabelInfo(null, nameof(SByte), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Sbyte, Sbyte, Sbyte) => (Sbyte)/Sbyte Clamp Operator")]
	public sealed class SbyteClampOperator : SingleReturnTernaryOperator<sbyte, sbyte, sbyte, sbyte>
	{
		protected override Func<sbyte, sbyte, sbyte, sbyte> operation => DefaultOperators.SbyteClamp;
	}
}
