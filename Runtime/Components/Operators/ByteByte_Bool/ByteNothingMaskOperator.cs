// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ByteByte_Bool
{
	[CustomLabelInfo("Value", nameof(Byte), 0)]
	[CustomLabelInfo("Mask", nameof(Byte), 1)]
	[CustomLabelInfo("Is Nothing In Mask", nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Byte, Byte) => (Bool)/Byte Nothing Mask Operator")]
	public sealed class ByteNothingMaskOperator : SingleReturnBinaryOperator<byte, byte, bool>
	{
		protected override Func<byte, byte, bool> operation => DefaultOperators.ByteNothingMask;
	}
}
