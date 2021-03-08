namespace TrueFalse
{
	public class Question
	{
		///<summary>
		///Вопрос
		/// </summary>
		public string Text { get; set; }

		///<summary>
		///Ответ
		/// </summary>
		public bool TrueFalse { get; set; }

		public Question () { }

		public Question (string text, bool trueFalse)
		{
			Text = text;
			TrueFalse = trueFalse;
		}
	}
}