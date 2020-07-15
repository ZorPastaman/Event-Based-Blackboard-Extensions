// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolByteByte_Byte
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Byte), 1)]
	[CustomLabelInfo("False", nameof(Byte), 2)]
	[CustomLabelInfo(null, nameof(Byte), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Byte, Byte) => (Byte)/Byte Conditional Operator")]
	public sealed class ByteConditionalOperator : SingleReturnTernaryOperator<bool, byte, byte, byte>
	{
		protected override Func<bool, byte, byte, byte> operation => DefaultOperators.ByteConditional;
	}
}
