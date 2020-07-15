// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ShortShort_Bool
{
	[CustomLabelInfo(null, nameof(Int16), 0)]
	[CustomLabelInfo(null, nameof(Int16), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Short, Short) => (Bool)/Short Greater Operator")]
	public sealed class ShortGreaterOperator : SingleReturnBinaryOperator<short, short, bool>
	{
		protected override Func<short, short, bool> operation => DefaultOperators.ShortGreater;
	}
}
