// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntIntInt_Int
{
	[CustomLabelInfo("Value", nameof(Int32), 0)]
	[CustomLabelInfo("Min", nameof(Int32), 1)]
	[CustomLabelInfo("Max", nameof(Int32), 2)]
	[CustomLabelInfo("Clamped", nameof(Int32), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int, Int) => (Int)/Int Clamp Operator")]
	public sealed class IntClampOperator : SingleReturnTernaryOperator<int, int, int, int>
	{
		protected override Func<int, int, int, int> operation => DefaultOperators.IntClamp;
	}
}
