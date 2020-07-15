// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ByteByteByte_Byte
{
	[CustomLabelInfo("Value", nameof(Byte), 0)]
	[CustomLabelInfo("Min", nameof(Byte), 1)]
	[CustomLabelInfo("Max", nameof(Byte), 2)]
	[CustomLabelInfo(null, nameof(Byte), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Byte, Byte, Byte) => (Byte)/Byte Clamp Operator")]
	public sealed class ByteClampOperator : SingleReturnTernaryOperator<byte, byte, byte, byte>
	{
		protected override Func<byte, byte, byte, byte> operation => DefaultOperators.ByteClamp;
	}
}
