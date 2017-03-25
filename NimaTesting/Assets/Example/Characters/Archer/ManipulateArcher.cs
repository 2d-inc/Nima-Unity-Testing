using System;
using System.IO;
using UnityEngine;
using Nima.Math2D;

namespace Nima.Unity
{
	public class ManipulateArcher : MonoBehaviour, IActorManipulationController
	{
		private GameObject m_ArchersSpinalColumn;
		public void SetupManipulator(ActorBaseComponent actorBase)
		{
			m_ArchersSpinalColumn = actorBase.GetActorGameObject("Spine");
		}

		public void ManipulateActor(ActorBaseComponent actorBase)
		{
			if(m_ArchersSpinalColumn == null)
			{
				return;
			}
			m_ArchersSpinalColumn.transform.Rotate(new Vector3(0.0f, 0.0f, (float)Math.Sin(Time.time) * 30.0f), Space.Self);
		}
	}
}