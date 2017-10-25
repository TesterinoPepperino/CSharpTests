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
			this.text = text + "aay lmao Lamar Davis";
			return text;
		}


		public override string ToString() {
		return this.modifytext();
		}
	}
}

