// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Short_Short
{
	[CustomLabelInfo(null, nameof(Int16), 0)]
	[CustomLabelInfo(null, nameof(Int16), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Short) => (Short)/Short Abs Operator")]
	public sealed class ShortAbsOperator : SingleReturnUnaryOperator<short, short>
	{
		protected override Func<short, short> operation => DefaultOperators.ShortAbs;
	}
}
