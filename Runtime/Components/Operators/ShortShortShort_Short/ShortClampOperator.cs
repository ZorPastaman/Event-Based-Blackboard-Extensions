// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.ShortShortShort_Short
{
	[CustomLabelInfo("Value", nameof(Int16), 0)]
	[CustomLabelInfo("Min", nameof(Int16), 1)]
	[CustomLabelInfo("Max", nameof(Int16), 2)]
	[CustomLabelInfo(null, nameof(Int16), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Short, Short, Short) => (Short)/Short Clamp Operator")]
	public sealed class ShortClampOperator : SingleReturnTernaryOperator<short, short, short, short>
	{
		protected override Func<short, short, short, short> operation => DefaultOperators.ShortClamp;
	}
}
