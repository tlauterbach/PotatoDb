using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace PotatoDb.Editor {

	/// <summary>
	/// String struct used to identify assets/objects and link them
	/// </summary>
	public struct ItemID : IEquatable<ItemID> {

		[SerializeField]
		private string m_id;
		[SerializeField]
		private int m_hash;

		public ItemID(string id) {
			m_id = id;
			m_hash = BuildHash(m_id);
		}

		public static bool operator ==(ItemID lhs, ItemID rhs) {
			return lhs.Equals(rhs);
		}
		public static bool operator !=(ItemID lhs, ItemID rhs) {
			return !lhs.Equals(rhs);
		}

		public static implicit operator string(ItemID item) {
			return item.m_id;
		}

		public bool Equals(ItemID other) {
			return m_hash == other.m_hash;
		}

		public override int GetHashCode() {
			return m_hash;
		}

		public override bool Equals(object obj) {
			if (obj == null || !(obj is ItemID)) {
				return false;
			}
			return Equals((ItemID)obj);
		}

		public override string ToString() {
			return m_id;
		}

		private static int BuildHash(string id) {
			return -1269635712 + EqualityComparer<string>.Default.GetHashCode(id);
		}
	}

}