// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.RectInt_Vector2
{
	[CustomLabelInfo(null, nameof(RectInt), 0)]
	[CustomLabelInfo(null, nameof(Vector2), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(RectInt) => (Vector2)/RectInt Center Operator")]
	public sealed class RectIntCenterOperator : SingleReturnUnaryOperator<RectInt, Vector2>
	{
		protected override Func<RectInt, Vector2> operation => DefaultOperators.RectIntCenter;
	}
}
