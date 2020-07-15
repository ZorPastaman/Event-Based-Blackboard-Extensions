// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Int_String
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int) => (String)/Int ToString Operator")]
	public sealed class IntToStringOperator : SingleReturnUnaryOperator<int, string>
	{
		protected override Func<int, string> operation => DefaultOperators.IntToString;
	}
}
