using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace PotatoDb.Editor {

	[Serializable, JsonObject("Schema")]
	public class Schema {

		[JsonProperty("name")]
		private string m_name = string.Empty;
		[JsonProperty("fields")]
		private List<SchemaField> m_fields = new List<SchemaField>();

		public string Name { get { return m_name; } }
		public IEnumerable<SchemaField> Fields { get { return m_fields; } }
		public int Count { get { return m_fields.Count; } }

		public void AddField(SchemaField.Type type) {
			throw new NotImplementedException();
		}
		public void RemoveField(int index) {
			throw new NotImplementedException();
		}
		public void Rename(string newName) {
			throw new NotImplementedException();
		}

	}


}