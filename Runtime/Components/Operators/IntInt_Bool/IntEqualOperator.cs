// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntInt_Bool
{
	[CustomLabelInfo(null, nameof(Int32), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int) => (Bool)/Int Equal Operator")]
	public sealed class IntEqualOperator : SingleReturnBinaryOperator<int, int, bool>
	{
		protected override Func<int, int, bool> operation => DefaultOperators.IntEqual;
	}
}
