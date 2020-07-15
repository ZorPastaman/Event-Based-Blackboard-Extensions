// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Byte_Byte
{
	[CustomLabelInfo(null, nameof(Byte), 0)]
	[CustomLabelInfo(null, nameof(Byte), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Byte) => (Byte)/Byte Decrement Operator")]
	public sealed class ByteDecrementOperator : SingleReturnUnaryOperator<byte, byte>
	{
		protected override Func<byte, byte> operation => DefaultOperators.ByteDecrement;
	}
}
