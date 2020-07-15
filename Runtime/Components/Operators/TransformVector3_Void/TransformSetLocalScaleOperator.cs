// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.TransformVector3_Void
{
	[CustomLabelInfo(null, nameof(Transform), 0)]
	[CustomLabelInfo(null, nameof(Vector3), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Transform, Vector3) => (Void)/Transform Set LocalScale Operator")]
	public sealed class TransformSetLocalScaleOperator : NoReturnBinaryOperator<Transform, Vector3>
	{
		protected override Action<Transform, Vector3> operation => DefaultOperators.TransformSetLocalScale;
	}
}
