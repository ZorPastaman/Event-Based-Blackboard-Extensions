// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.PropertyNamePropertyName_Bool
{
	[CustomLabelInfo(null, nameof(PropertyName), 0)]
	[CustomLabelInfo(null, nameof(PropertyName), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(PropertyName, PropertyName) => (Bool)/Property Name Not Equal Operator")]
	public sealed class PropertyNameNotEqualOperator : SingleReturnBinaryOperator<PropertyName, PropertyName, bool>
	{
		protected override Func<PropertyName, PropertyName, bool> operation => DefaultOperators.PropertyNameNotEqual;
	}
}
