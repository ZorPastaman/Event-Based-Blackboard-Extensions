// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;
using Object = UnityEngine.Object;

namespace Zor.EventBasedBlackboard.Components.Operators.Object_Bool
{
	[CustomLabelInfo(null, nameof(Object), 0)]
	[CustomLabelInfo(null, nameof(Boolean), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Object) => (Bool)/Object Exists Operator")]
	public sealed class ObjectExistsOperator : SingleReturnUnaryOperator<Object, bool>
	{
		protected override System.Func<Object, bool> operation => DefaultOperators.ObjectExists;
	}
}
