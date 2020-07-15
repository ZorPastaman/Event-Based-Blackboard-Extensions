// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.SbyteSbyte_Bool
{
	[CustomLabelInfo("Value", nameof(SByte), 0)]
	[CustomLabelInfo("Mask", nameof(SByte), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Sbyte, Sbyte) => (Bool)/Sbyte Anything Mask Operator")]
	public sealed class SbyteAnythingMaskOperator : SingleReturnBinaryOperator<sbyte, sbyte, bool>
	{
		protected override Func<sbyte, sbyte, bool> operation => DefaultOperators.SbyteAnythingMask;
	}
}
