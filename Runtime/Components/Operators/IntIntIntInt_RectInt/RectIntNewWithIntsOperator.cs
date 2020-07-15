// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.IntIntIntInt_RectInt
{
	[CustomLabelInfo("X Min", nameof(Int32), 0)]
	[CustomLabelInfo("Y Min", nameof(Int32), 1)]
	[CustomLabelInfo("Width", nameof(Int32), 2)]
	[CustomLabelInfo("Height", nameof(Int32), 3)]
	[CustomLabelInfo(null, nameof(RectInt), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Int, Int, Int, Int) => (RectInt)/RectInt New With Ints Operator")]
	public sealed class RectIntNewWithIntsOperator : SingleReturnQuaternaryOperator<int, int, int, int, RectInt>
	{
		protected override Func<int, int, int, int, RectInt> operation => DefaultOperators.RectIntNewWithInts;
	}
}
