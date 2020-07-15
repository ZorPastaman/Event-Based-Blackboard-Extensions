// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntInt_Int
{
	[CustomLabelInfo(null, nameof(Int32), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Int32), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int) => (Int)/Int Subtraction Operator")]
	public sealed class IntSubtractionOperator : SingleReturnBinaryOperator<int, int, int>
	{
		protected override Func<int, int, int> operation => DefaultOperators.IntSubtraction;
	}
}
