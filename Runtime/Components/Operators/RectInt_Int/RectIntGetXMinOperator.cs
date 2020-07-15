// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectInt_Int
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt) => (Int)/RectInt Get XMin Operator")]
	public sealed class RectIntGetXMinOperator : SingleReturnUnaryOperator<RectInt, int>
	{
		protected override Func<RectInt, int> operation => DefaultOperators.RectIntGetXMin;
	}
}
