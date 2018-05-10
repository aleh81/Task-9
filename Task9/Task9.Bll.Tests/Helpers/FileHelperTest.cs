using System;
using NUnit.Framework;
using Task9.BLL.Helpers;

namespace Task9.Bll.Tests.Helpers
{
	[TestFixture]
	class FileHelperTest
	{
		[Test]
		public void TestSaveFileDialog()
		{
				Assert.Catch<NullReferenceException>
				(InitNullOfArgumentFor_SaveFileMethod);
		}

		private void InitNullOfArgumentFor_SaveFileMethod()
		{
			FileHelper.SaveFileDialog(null);
		}
	}
}
