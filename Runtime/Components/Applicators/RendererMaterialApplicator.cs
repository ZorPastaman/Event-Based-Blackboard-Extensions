// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using UnityEngine.Scripting;

namespace Zor.EventBasedBlackboard.Components.Applicators
{
	/// <summary>
	/// <para>Applicator for <see cref="Renderer"/> <see cref="Material"/>.</para>
	/// <para>It contains main set methods and make it easy to set values into a
	/// <see cref="Renderer"/> <see cref="Material"/>.</para>
	/// </summary>
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ApplicatorsFolder + "Renderer Material Applicator")]
	public sealed class RendererMaterialApplicator : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField] private Renderer m_Renderer;
		[SerializeField] private string m_PropertyName;
#pragma warning restore CS0649

		private int m_propertyId;
		private bool m_initialized;

		private int propertyId
		{
			get
			{
				if (!m_initialized)
				{
					m_propertyId = Shader.PropertyToID(m_PropertyName);
					m_initialized = true;
				}

				return m_propertyId;
			}
		}

		[Preserve]
		public void SetFloat(float value)
		{
			m_Renderer.material.SetFloat(propertyId, value);
		}

		[Preserve]
		public void SetInt(int value)
		{
			m_Renderer.material.SetInt(propertyId, value);
		}

		[Preserve]
		public void SetColor(Color value)
		{
			m_Renderer.material.SetColor(propertyId, value);
		}

		[Preserve]
		public void SetVector(Vector4 value)
		{
			m_Renderer.material.SetVector(propertyId, value);
		}

		[Preserve]
		public void SetMatrix(Matrix4x4 value)
		{
			m_Renderer.material.SetMatrix(propertyId, value);
		}

		[Preserve]
		public void SetTexture(Texture value)
		{
			m_Renderer.material.SetTexture(propertyId, value);
		}
	}
}
