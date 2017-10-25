using System;

namespace lmao
{
	public class Writer
	{
		string text = null;
		public Writer (string text)
		{
			this.text = text;
		}
			
		private string modifytext() {
			this.text = text + "aay lmao";
			return text;
		}

		private string extraMethod()
		{
		}

		public override string ToString() {
		return this.modifytext();
		}
	}
}

