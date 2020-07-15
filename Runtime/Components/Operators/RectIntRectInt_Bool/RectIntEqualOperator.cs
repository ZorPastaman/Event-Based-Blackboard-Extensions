// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectIntRectInt_Bool
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(RectInt), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt, RectInt) => (Bool)/RectInt Equal Operator")]
	public sealed class RectIntEqualOperator : SingleReturnBinaryOperator<RectInt, RectInt, bool>
	{
		protected override Func<RectInt, RectInt, bool> operation => DefaultOperators.RectIntEqual;
	}
}
