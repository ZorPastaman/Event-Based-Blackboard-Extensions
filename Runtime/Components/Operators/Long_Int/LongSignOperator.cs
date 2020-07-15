// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Long_Int
{
	[CustomLabelInfo(null, nameof(Int64), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Long) => (Int)/Long Sign Operator")]
	public sealed class LongSignOperator : SingleReturnUnaryOperator<long, int>
	{
		protected override Func<long, int> operation => DefaultOperators.LongSign;
	}
}
