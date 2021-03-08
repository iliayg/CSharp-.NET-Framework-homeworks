using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TrueFalse
{
	public class TrueFalse
	{
		#region Private Fields

		private List<Question> list;
		private string fileName;
		#endregion

		public string FileName
		{ set { fileName = value; } }

		public int Count
		{ get { return list.Count; } }

		public Question this[ int index ]
		{
			get { return list[ index ]; }
		}

		#region Constructors
		public TrueFalse (string fileName)
		{
			this.fileName = fileName;
			list = new List<Question>();
		}
		#endregion

		public void Add (string text, bool trueFalse)
		{
			list.Add(new Question(text, trueFalse));
		}

		public void Remove (int index)
		{
			if (list != null && index < list.Count && index >= 0)
				list.RemoveAt(index);
		}

		public void Save ()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
			using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
				xmlSerializer.Serialize(stream, list);
		}

		public void Load ()
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
			using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
				list = (List < Question >)xmlSerializer.Deserialize(stream);
		}
	}
}