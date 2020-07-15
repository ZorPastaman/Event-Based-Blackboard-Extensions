// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Int_Bool
{
	[CustomLabelInfo(null, nameof(Int32), 0)]
	[CustomLabelInfo(null, nameof(Boolean), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int) => (Bool)/Int Is Power Of Two Operator")]
	public sealed class IntIsPowerOfTwoOperator : SingleReturnUnaryOperator<int, bool>
	{
		protected override Func<int, bool> operation => DefaultOperators.IntIsPowerOfTwo;
	}
}
