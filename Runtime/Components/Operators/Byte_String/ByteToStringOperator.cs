// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Byte_String
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Byte) => (String)/Byte ToString Operator")]
	public sealed class ByteToStringOperator : SingleReturnUnaryOperator<byte, string>
	{
		protected override Func<byte, string> operation => DefaultOperators.ByteToString;
	}
}
