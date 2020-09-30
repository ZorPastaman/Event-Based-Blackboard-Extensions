// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;

namespace Zor.EventBasedBlackboard.Components.Operators
{
	/// <summary>
	/// <para>Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/>
	/// and <typeparamref name="TSecondOperand"/> that returns nothing.</para>
	/// <para>Inherit this to implement a new operator.</para>
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over
	/// <see cref="Zor.EventBasedBlackboard.Workers.Operating.NoReturnBinaryOperator{TFirstOperand,TSecondOperand}"/>
	/// </remarks>
	public abstract class NoReturnBinaryOperator<TFirstOperand, TSecondOperand> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField, CustomLabel(0)] private BlackboardPropertyReference m_FirstOperand;
		[SerializeField, CustomLabel(1)] private BlackboardPropertyReference m_SecondOperand;
		[SerializeField] private bool m_OperateOnEnable = true;
#pragma warning restore CS0649

		private Workers.Operating.NoReturnBinaryOperator<TFirstOperand, TSecondOperand> m_operator;

		public BlackboardPropertyReference firstOperand
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_FirstOperand;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_FirstOperand = value;
		}

		public BlackboardPropertyReference secondOperand
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_SecondOperand;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_SecondOperand = value;
		}

		public bool operateOnEnable
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OperateOnEnable;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_OperateOnEnable = value;
		}

		/// <summary>
		/// Operation function.
		/// </summary>
		[NotNull]
		protected abstract Action<TFirstOperand, TSecondOperand> operation { get; }

		[ContextMenu("Recreate Operator")]
		public void RecreateOperator()
		{
			if (m_operator == null)
			{
				return;
			}

			bool wasEnabled = m_operator.enabled;
			m_operator.enabled = false;
			Awake();
			m_operator.enabled = wasEnabled;
		}

		private void Awake()
		{
			m_operator = new Workers.Operating.NoReturnBinaryOperator<TFirstOperand, TSecondOperand>(
				m_FirstOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_FirstOperand.propertyName),
				m_SecondOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_SecondOperand.propertyName),
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
