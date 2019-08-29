using Newtonsoft.Json;
using System;

namespace PotatoDb.Editor {

	/// <summary>
	/// Definition of a Schema field (ie, column) to be displayed when editing 
	/// data that use a Schema.
	/// </summary>
	[Serializable]
	public sealed class SchemaField {

		public enum Type {
			Id = 0,
			Int = 1,
			Float = 2,
			Double = 3,
			Bool = 4,
			String = 5,
			Link = 6
		}

		public string DisplayName { get { return m_displayName; } }

		public Type FieldType { get { return m_fieldType; } }

		[JsonProperty("displayName")]
		private string m_displayName = string.Empty;
		[JsonProperty("fieldType")]
		private Type m_fieldType = Type.Id;

		[JsonProperty("minValue")]
		private double m_min = double.MinValue;
		[JsonProperty("maxValue")]
		private double m_max = double.MaxValue;
		[JsonProperty("defaultValue")]
		private double m_default = 0.0;
		[JsonProperty("maxCharacters")]
		private uint m_maxCharacters = uint.MaxValue;
		[JsonProperty("linkType")]
		private string m_linkType = string.Empty;
	}

}