﻿using System.Collections.Generic;
using UnityEngine;

// compile with: -doc:DocFileName.xml 
namespace CustomMSLibrary.Unity {
	public static class CustomUnityExtensions {
		public static bool ContainsLayer(this LayerMask mask, int layer) {
			return mask == (mask | (1 << layer));
		}

		public static List<Transform> GetAllChildren(this Transform transform) {
			List<Transform> children = new List<Transform>();
			int c = transform.childCount;
			for (int i = 0; i < c; i++)
			{
				var child = transform.GetChild(i);
				if (child != null) children.Add(child);
			}
			return children;
		}

		public static LayerMask ToLayerMask(this int layer) {
			return (1 << layer);
		}

		/// <summary>
		/// Returns a vector from the element calling the method to the parameter target.
		/// </summary>
		/// <returns></returns>
		public static Vector3 RelativePosTo(this Component origin, Component target) {
			return (target.transform.position - origin.transform.position);
		}

		public static Vector2 RotateTowards2D(this Vector2 source, Vector2 target, float maxAngle = 180) {
			float deltaAngle = Vector2.SignedAngle(source, target);
			deltaAngle = Mathf.Abs(deltaAngle) > maxAngle ? maxAngle * Mathf.Sign(deltaAngle) : deltaAngle;
			return Quaternion.Euler(0, 0, deltaAngle) * source;
		}

		public static Vector3 FlipYZ(this Vector3 vector) {
			var z = vector.z;
			vector.z = vector.y;
			vector.y = z;
			return vector;
		}

		/// <summary>
		/// Converts a vector3 to a Vector2 using x and z values instead of x and y.
		/// </summary>
		public static Vector2 ToVector2Z(this Vector3 vector) => new Vector2(vector.x, vector.z);

		/// <summary>
		/// Returns the vector with its x value set to 0.
		/// </summary>
		public static Vector3 ZeroX(this Vector3 vector) {
			vector.x = 0;
			return vector;
		}

		/// <summary>
		/// Returns the vector with its y value set to 0.
		/// </summary>
		public static Vector3 ZeroY(this Vector3 vector) {
			vector.y = 0;
			return vector;
		}

		/// <summary>
		/// Returns the vector with its z value set to 0.
		/// </summary>
		public static Vector3 ZeroZ(this Vector3 vector) {
			vector.z = 0;
			return vector;
		}

		/// <summary>
		/// Returns the vector with its x value set to 1.
		/// </summary>
		public static Vector3 OneX(this Vector3 vector) {
			vector.x = 1;
			return vector;
		}

		/// <summary>
		/// Returns the vector with its y value set to 1.
		/// </summary>
		public static Vector3 OneY(this Vector3 vector) {
			vector.y = 1;
			return vector;
		}

		/// <summary>
		/// Returns the vector with its z value set to 1.
		/// </summary>
		public static Vector3 OneZ(this Vector3 vector) {
			vector.z = 1;
			return vector;
		}

	}
}