// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectIntInt_RectInt
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(RectInt), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, Int) => (RectInt)/RectInt Set YMin Operator")]
	public sealed class RectIntSetYMinOperator : SingleReturnBinaryOperator<RectInt, int, RectInt>
	{
		protected override Func<RectInt, int, RectInt> operation => DefaultOperators.RectIntSetYMin;
	}
}
