// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Short_Int
{
	[CustomLabelInfo(null, nameof(Int16), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Short) => (Int)/Short Sign Operator")]
	public sealed class ShortSignOperator : SingleReturnUnaryOperator<short, int>
	{
		protected override Func<short, int> operation => DefaultOperators.ShortSign;
	}
}
