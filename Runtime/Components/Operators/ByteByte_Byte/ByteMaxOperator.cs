// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ByteByte_Byte
{
	[CustomLabelInfo(null, nameof(Byte), 0)]
	[CustomLabelInfo(null, nameof(Byte), 1)]
	[CustomLabelInfo(null, nameof(Byte), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Byte, Byte) => (Byte)/Byte Max Operator")]
	public sealed class ByteMaxOperator : SingleReturnBinaryOperator<byte, byte, byte>
	{
		protected override Func<byte, byte, byte> operation => DefaultOperators.ByteMax;
	}
}
