// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolPropertyNamePropertyName_PropertyName
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(PropertyName), 1)]
	[CustomLabelInfo("False", nameof(PropertyName), 2)]
	[CustomLabelInfo(null, nameof(PropertyName), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, PropertyName, PropertyName) => (PropertyName)/PropertyName Conditional Operator")]
	public sealed class PropertyNameConditionalOperator :
		SingleReturnTernaryOperator<bool, PropertyName, PropertyName, PropertyName>
	{
		protected override Func<bool, PropertyName, PropertyName, PropertyName> operation =>
			DefaultOperators.PropertyNameConditional;
	}
}
