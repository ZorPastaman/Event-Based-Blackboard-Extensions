// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using UnityEngine;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;

namespace Zor.EventBasedBlackboard.Components.Operators
{
	/// <summary>
	/// <para>Operates an operation with a blackboard property of type <typeparamref name="TOperand"/>
	/// that returns nothing.</para>
	/// <para>Inherit this to implement a new operator.</para>
	/// </summary>
	/// <typeparam name="TOperand">Operand value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over
	/// <see cref="Zor.EventBasedBlackboard.Workers.Operating.NoReturnUnaryOperator{TOperand}"/>
	/// </remarks>
	public abstract class NoReturnUnaryOperator<TOperand> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField, CustomLabel(0)] private BlackboardPropertyReference m_Operand;
		[SerializeField] private bool m_OperateOnEnable = true;
#pragma warning restore CS0649

		private Workers.Operating.NoReturnUnaryOperator<TOperand> m_operator;

		/// <summary>
		/// Operation function.
		/// </summary>
		[NotNull]
		protected abstract Action<TOperand> operation { get; }

		private void Awake()
		{
			m_operator = new Workers.Operating.NoReturnUnaryOperator<TOperand>(
				m_Operand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_Operand.propertyName),
				m_OperateOnEnable,
				operation);
		}

		private void OnEnable()
		{
			m_operator.enabled = true;
		}

		private void OnDisable()
		{
			m_operator.enabled = false;
		}
	}
}
